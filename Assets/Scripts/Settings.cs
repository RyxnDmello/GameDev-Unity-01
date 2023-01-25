using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class Settings : MonoBehaviour
{
    public Slider Volume;
    public AudioMixer Mix;

    private void Start()
    {
        SetVolume(PlayerPrefs.GetFloat("PlayerVolume"));
    }

    public void SetVolume(float Vol)
    {
        Mix.SetFloat("GameVolume", Vol);
        PlayerPrefs.SetFloat("PlayerVolume", Vol);
        Volume.value = PlayerPrefs.GetFloat("PlayerVolume");
    }
}
