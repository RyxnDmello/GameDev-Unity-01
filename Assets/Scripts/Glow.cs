using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Glow : MonoBehaviour
{
    [Header("COMPOENENTS")]
    public GameObject Glows;

    private void Start()
    {
        
    }

    public void Update()
    {
        if (PlayerPrefs.GetInt("Glowing") == 0)
        {
            Deactivate();
        }
        else if (PlayerPrefs.GetInt("Glowing") == 1)
        {
            Activation();
        }
    }

    public void Set()
    {
        PlayerPrefs.SetInt("Glowing", 0);
    }

    public void GlowGame()
    {
        if (PlayerPrefs.GetInt("Glowing") == 0)
        {
            PlayerPrefs.SetInt("Glowing", 1);
        }
        else if (PlayerPrefs.GetInt("Glowing") == 1)
        {
            PlayerPrefs.SetInt("Glowing", 0);
        }
    }

    public void Activation()
    {
        Glows.SetActive(true);
    }

    public void Deactivate()
    {
        Glows.SetActive(false);
    }
}
