using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MusicActive : MonoBehaviour
{
    public GameObject MusicObject;
    private AudioSource Source;
    int Scene;

    private void Start()
    {
        MusicObject = GameObject.FindGameObjectWithTag("GameMusic");
        Source = MusicObject.GetComponent<AudioSource>();

        Scene = SceneManager.GetActiveScene().buildIndex;
        if (Scene == 4)
        {
            Source.Play();
        }
    }

    private void Update()
    {
        QuitGame();
    }

    public void QuitGame()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            PlayerPrefs.SetInt("Glowing", 0);
            Application.Quit();
        }
    }
}
