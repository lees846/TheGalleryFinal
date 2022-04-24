using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class audioEndSceneSwap : MonoBehaviour
{
    public string sceneToLoad;
    public Animator UIFade;
    public string AnimationToPlay;
    AudioSource thisSongClip;
    
    void Start()
    {
        thisSongClip = GetComponent<AudioSource>();
    }
    void Update()
    {
        // if audiosource is over, change scene
        if (!thisSongClip.isPlaying){
            // when triggered, send to scene 2
            ChangeScene();
        }
    }
    void ChangeScene()
    {
        SceneManager.LoadScene(sceneToLoad);
    }

    void TransitionScene()
    {
        StartCoroutine(PlayTransition());
    }

    IEnumerator PlayTransition()
    {
        UIFade.SetTrigger(AnimationToPlay);
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene(sceneToLoad);
    }
}
