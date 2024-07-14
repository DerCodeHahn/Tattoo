using System.Collections;
using System.Collections.Generic;
using TreeEditor;
using UnityEngine;

[RequireComponent(typeof(LineRenderer))]
public class MoveLineRendererTexture : MonoBehaviour
{
    LineRenderer lineRenderer;
    [SerializeField] private float speed = 1f;
    [SerializeField] private float noiseSpeed = 1f;

    
    float offset = 0;
    private FractalNoise noise;
    void Start()
    {
        noise = new FractalNoise(1.0f, 1.0f, 8.0f);
        
        lineRenderer = GetComponent<LineRenderer>();
    }

    void Update()
    {
        offset += speed * Time.deltaTime * (1+noise.BrownianMotion(0, Time.time * noiseSpeed));
        lineRenderer.sharedMaterial.SetFloat("_Offset",offset);
    }
}
