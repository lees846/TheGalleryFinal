using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroy : MonoBehaviour
{
    void Awake()
    {
        // Code from https://docs.unity3d.com/ScriptReference/Object.DontDestroyOnLoad.html
        GameObject[] objs = GameObject.FindGameObjectsWithTag("quit");

        if (objs.Length > 1)
        {
            Destroy(this.gameObject);
        }

        DontDestroyOnLoad(this.gameObject);
    }
}
