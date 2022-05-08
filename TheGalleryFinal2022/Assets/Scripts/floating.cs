using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class floating : MonoBehaviour
{
    public Vector3 startPosition; 
    public float offset = 0f;
    public float amplitude = 0f;
    public float frequency = 0f;


    void Start()
    {
        startPosition = transform.localPosition;
    }
    // ref local position
    // 
    void Update()
    {
        Vector3 newPosition = new Vector3(startPosition.x + Mathf.Sin(frequency*Time.frameCount + offset) * amplitude,
        startPosition.y + Mathf.Sin(frequency*Time.frameCount) * amplitude,
        startPosition.z);

        transform.localPosition = newPosition;
    }
}
