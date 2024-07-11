using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(LineRenderer))]
public class MoveLineRenderWidth : MonoBehaviour
{
    private LineRenderer lineRenderer;

    [SerializeField] private float speed = 1;
    // Start is called before the first frame update
    void Start()
    {
        lineRenderer = GetComponent<LineRenderer>();
        lineRenderer.widthCurve.postWrapMode = WrapMode.Loop;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        AnimationCurve curve = lineRenderer.widthCurve;
        Keyframe[] keyframes = curve.keys;
        
        for (var i = 0; i < keyframes.Length; i++)
        {
            keyframes[i].time += speed * Time.fixedDeltaTime;
            keyframes[i].time %= 1;
        }

        curve.keys = keyframes;
        
        lineRenderer.widthCurve = curve;
    }
}
