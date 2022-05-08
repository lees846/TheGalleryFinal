using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// This script will make the image tilt forward so it's open at 29 seconds
// It will instantiate a new object in the frame
// The new object sends user to next scene when collided with

public class openFrame : MonoBehaviour
{
    public float MovementTime = 2.5f;
    private Quaternion TargetRotation;
    float totalTime = 0f;
    public Quaternion StartingRotation = Quaternion.EulerAngles(-105, 0, 0);
    public AudioSource songIntroClip;
    public GameObject Teleporter;
    public Transform PortalTarget;
    void Start()
    {
        totalTime = 0f;
        StartingRotation = transform.localRotation;
        TargetRotation = Quaternion.EulerAngles(105, 0, 0);
        StartCoroutine(CountingSeconds());
    }

    // From https://docs.unity3d.com/ScriptReference/WaitForSeconds.html
    // and https://docs.unity3d.com/ScriptReference/Quaternion.Lerp.html.
    // Jason also helped
     IEnumerator CountingSeconds()
     {
         //start song 
         while (songIntroClip.time <= 29f)
         {
             yield return null;
         }
        GameObject portal = Instantiate(Teleporter, PortalTarget.position, Quaternion.identity);
            portal.name = "Portal";
            portal.layer = 0;
            
         while (totalTime < MovementTime)
         {
            yield return null;
            totalTime += Time.deltaTime;
            transform.localRotation = Quaternion.Lerp(StartingRotation, TargetRotation, totalTime/MovementTime);
            // Debug.Log(totalTime);
            // Debug.Log("Target: " + TargetRotation + " Start: " + StartingRotation);

         }
           
     }
}
