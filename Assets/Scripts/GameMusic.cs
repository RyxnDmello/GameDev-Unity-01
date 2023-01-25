using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMusic : MonoBehaviour
{
    GameObject[] MusicObject;

    public void Awake()
    {
        MusicObject = GameObject.FindGameObjectsWithTag("GameMusic");
        
        if (MusicObject.Length > 1)
        {
            Destroy(this.gameObject);
        }
        DontDestroyOnLoad(this.gameObject);
    }
}
