using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// This script will make the image tilt forward so it's open at 29 seconds
// It will instantiate a new object in the frame
// The new object sends user to next scene when collided with

public class openFrame : MonoBehaviour
{
    // public float MovementTime = 1.0f;
    // public Quaternion TargetRotation;
    // // private Quaternion Target;
    // float totalTime = 0f;
    // public Quaternion StartingRotation;

    public AudioSource songIntroClip;
    public GameObject Teleporter;
    void Start()
    {
        // totalTime = 0f;

        // StartingRotation = transform.rotation;
        // TargetRotation = new Quaternion(-104, 0, 0, 1);
        
        StartCoroutine(CountingSeconds());
    }

    // Update is called once per frame
    void Update()
    {
    //     totalTime += Time.deltaTime;
    //     if(totalTime >= MovementTime) totalTime = MovementTime;
    //     UpdateTargetRotation();
    //     transform.rotation = Quaternion.Lerp(StartingRotation, TargetRotation, totalTime/MovementTime);
   
    }

    // void UpdateTargetRotation()
    // {
    //     TargetRotation = transform.rotation;
    // }

    // Non-Gradual transform:
    // opens at 29 sec
    // void OnTriggerEnter(Collider other)
    // {
    //     if (other.gameObject.CompareTag("Player")){
    //         // when triggered, rotate the door from the hinge
    //         transform.Rotate(-105, 0, 0);

    //         GameObject portal = Instantiate(Teleporter);
    //         portal.name = "Portal";
    //         portal.layer = 0;

    //     }
    // }

    // From https://docs.unity3d.com/ScriptReference/WaitForSeconds.html
     IEnumerator CountingSeconds()
     {

         //start song 


         while (songIntroClip.time <= 29f)
         {
             yield return null;
         }

            transform.Rotate(-105, 0, 0);

            GameObject portal = Instantiate(Teleporter);
            portal.name = "Portal";
            portal.layer = 0;
        //yield on a new YieldInstruction that waits for 5 seconds.
        // yield return new WaitForSeconds(30);

        // open = true;
     }
}
