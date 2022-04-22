using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// Creates slight hover effect
public class hover : MonoBehaviour
{
    public float amplitude = 2f;
    public float frequency = 0.03f;
    public float offset = 0f;

    public float speed;
    public float height;

    // Update is called once per frame
    void Update()
    {
        Vector3 newPosition = new Vector3(transform.position.x,
        height * Mathf.Sin(speed * Time.frameCount + offset) + 3,
        transform.position.z);

        transform.position = newPosition;
    }
}
