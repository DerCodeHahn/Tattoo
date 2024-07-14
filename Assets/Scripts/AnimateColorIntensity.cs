using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimateColorIntensity : MonoBehaviour
{
    Material material;
    float timer = 0;
    [SerializeField] float speed = 1f;
    [SerializeField] float offset = 0;
    [SerializeField] float amplitude = 1;
    // Start is called before the first frame update
    void Start()
    {
        material = GetComponent<Renderer>().sharedMaterial;
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime * speed;
        float intensity =  offset + Mathf.PerlinNoise1D(timer) * amplitude;
        material.SetFloat("_Intensity", intensity);
    }
}
