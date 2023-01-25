using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class FunRoom : MonoBehaviour
{
    public TextMeshProUGUI Text;

    public void Update()
    {
        if (PlayerPrefs.GetInt("PlayerScore") > 0)
        {
            Text.text = "HIGH SCORE: " + PlayerPrefs.GetInt("PlayerScore").ToString();
        }
        else
        {
            Text.text = "HIGH SCORE: UNRATED";
        }
    }

    public void Set()
    {
        PlayerPrefs.SetInt("PlayerColor", 0);
    }

    public void Red()
    {
        PlayerPrefs.SetInt("PlayerColor", 1);
    }

    public void Blue()
    {
        PlayerPrefs.SetInt("PlayerColor", 2);
    }

    public void Green()
    {
        PlayerPrefs.SetInt("PlayerColor", 3);
    }

    public void Yellow()
    {
        PlayerPrefs.SetInt("PlayerColor", 4);
    }

    public void Pink()
    {
        PlayerPrefs.SetInt("PlayerColor", 5);
    }

    public void Purple()
    {
        PlayerPrefs.SetInt("PlayerColor", 6);
    }

    public void LightBlue()
    {
        PlayerPrefs.SetInt("PlayerColor", 7);
    }

    public void Orange()
    {
        PlayerPrefs.SetInt("PlayerColor", 8);
    }

    public void Peach()
    {
        PlayerPrefs.SetInt("PlayerColor", 9);
    }

    public void LightYes()
    {
        PlayerPrefs.SetInt("PlayerColor", 10);
    }
}
