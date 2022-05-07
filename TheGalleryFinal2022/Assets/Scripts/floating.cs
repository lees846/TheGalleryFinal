using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class floating : MonoBehaviour
{
    public Vector3 startPosition; 
    public float offset = 0f;

    void Start()
    {
        startPosition = transform.localPosition;
    }
    // ref local position
    // 
    void Update()
    {
        Vector3 newPosition = new Vector3(startPosition.x,
        startPosition.y + Mathf.Sin(Time.frameCount + offset),
        startPosition.z);
    }
}
