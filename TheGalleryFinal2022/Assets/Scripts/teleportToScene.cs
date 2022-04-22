using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class teleportToScene : MonoBehaviour
{
    public string sceneToLoad;
    public Animator UIFade;

    public string AnimationToPlay;
    
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player")){
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
