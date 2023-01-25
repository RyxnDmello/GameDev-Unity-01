using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameWalls : MonoBehaviour
{
    Player Play;

    private void Start()
    {
        Play = FindObjectOfType<Player>();
    }

    
}
