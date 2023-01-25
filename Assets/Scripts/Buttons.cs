using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buttons: MonoBehaviour
{
    AudioSource Click;

    private void Start()
    {
        Click = GetComponent<AudioSource>();
        Click.volume = 5f;
    }

    public void OnClick()
    {
        Click.Play();
    }
}
