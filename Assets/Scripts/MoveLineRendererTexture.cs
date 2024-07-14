using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(LineRenderer))]
public class MoveLineRendererTexture : MonoBehaviour
{
    LineRenderer lineRenderer;
    [SerializeField] private float speed = 1f;
    [SerializeField] private float noiseSpeed = 1f;

    
    float offset = 0;
    void Start()
    {
        lineRenderer = GetComponent<LineRenderer>();
    }

    void Update()
    {
        offset += speed * Time.deltaTime * (1+Mathf.PerlinNoise1D(Time.time * noiseSpeed));
        lineRenderer.sharedMaterial.SetFloat("_Offset",offset);
    }
}
