using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// This script makes a light withing any given frame intensify 
// when collided with by the player. 
// I'm going to manipulate the light intensity on a collision
public class frameLightEffect : MonoBehaviour
{
    public float activeIntensity;
    public Light frameLight;
    void Start()
    {
        gameObject.GetComponent<frameLightEffect>().frameLight.intensity = 5f;
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            BrightenLight();
        }
    }

    void BrightenLight()
    {
        frameLight.intensity = activeIntensity;

    }
}
