using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomRoation : MonoBehaviour
{
    [SerializeField] private Vector3 speed = Vector3.one;
    [SerializeField] private float noiseSpeed = 1f;
    
    Vector3 offset = Vector3.zero;
    
    void Update()
    {
        offset = speed * (Time.deltaTime * (Mathf.PerlinNoise(0, Time.time * noiseSpeed)));
        transform.Rotate(offset);
    }
}
