using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Instead of brightening the lights, this script shuts them off
// and adds a blockage to the frames that are passed through
public class breakFrame : MonoBehaviour
{
    public float activeIntensity;
    public Light frameLight;
    public GameObject FrameFiller;
    private Vector3 lightLocation;
    private Quaternion lightRotation;
    
    void Start()
    {
        // reference https://docs.unity3d.com/530/Documentation/ScriptReference/Light-intensity.html
        gameObject.GetComponent<breakFrame>().frameLight.intensity = 10f;
        lightLocation = gameObject.GetComponent<breakFrame>().frameLight.transform.position;
        lightRotation = gameObject.GetComponent<breakFrame>().frameLight.transform.rotation;
        // Debug.Log(lightLocation);
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            BreakFrame();
        }
    }

    void BreakFrame()
    {
        FrameFiller.transform.localPosition = lightLocation;
        FrameFiller.transform.localRotation = lightRotation;
        // Debug.Log("You broke it");
        frameLight.intensity = activeIntensity;
        GameObject frameBlock = Instantiate(FrameFiller);
            frameBlock.name = "FrameBlock";
            frameBlock.layer = 0;
        
    }
}
