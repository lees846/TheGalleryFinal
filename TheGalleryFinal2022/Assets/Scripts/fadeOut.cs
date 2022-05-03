using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fadeOut : MonoBehaviour
{

    public Animator UIFade;
    public string AnimationToPlay;
    AudioSource thisSongClip;

    void Start()
    {
        thisSongClip = GetComponent<AudioSource>();
        StartCoroutine(CountingSeconds());
    }

    IEnumerator                                                                                                                                                                                                                                                                                      CountingSeconds()
    {
        // wait until audiosource reaches boom sound
        while (thisSongClip.time <= 23)
        {
            yield return null;
        } 

        // start fade
        FadeToBlack();
        Debug.Log(thisSongClip.time);
    }

    void FadeToBlack()
    {
        UIFade.SetTrigger(AnimationToPlay);
    }
}
