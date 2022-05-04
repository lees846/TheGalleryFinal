using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class fadeOut : MonoBehaviour
{

    public Animator UIFade;
    public string sceneToLoad;
    public string AnimationToPlay;
    AudioSource thisSongClip;

    void Start()
    {
        thisSongClip = GetComponent<AudioSource>();
        StartCoroutine(CountingSeconds());
    }

    IEnumerator CountingSeconds()
    {
        // wait until audiosource reaches boom sound
        while (thisSongClip.time <= 23.5f)
        {
            yield return null;
        } 

        // start fade
        FadeToBlack();
        // Debug.Log(thisSongClip.time);

        yield return new WaitForSeconds(16f);
        SceneManager.LoadScene(sceneToLoad);
    }

    void FadeToBlack()
    {
        UIFade.Play(AnimationToPlay);
    }
}
