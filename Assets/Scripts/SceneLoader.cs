using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public SpriteRenderer Play;
    public AudioMixer Mix;

    public void LoadMainScene()
    {
        StartCoroutine(WaitTimeGameplay());
    }

    public void LoadControlsScene()
    {
        StartCoroutine(WaitTimeControlsScene());
    }

    public void LoadMainMenu()
    {
        StartCoroutine(WaitTimeMainMenu());
    }

    public void LoadFunRoomScene()
    {
        StartCoroutine(WaitTimeFunRoom());
    }

    public void Settings()
    {
        StartCoroutine(WaitTimeSettings());
    }

    public void QuitGame()
    {
        StartCoroutine(WaitTimeQuit());
    }

    public void ResetGame()
    {
        PlayerPrefs.SetInt("PlayerScore", 0);
        PlayerPrefs.SetInt("PlayerColor", 0);

        PlayerPrefs.SetFloat("PlayerVolume", 0);
        Mix.SetFloat("GameVolume", 0);
    }

    IEnumerator WaitTimeSettings()
    {
        yield return new WaitForSeconds(0.2f);
        SceneManager.LoadScene("Settings");
    }

    IEnumerator WaitTimeControlsScene()
    {
        yield return new WaitForSeconds(0.2f);
        SceneManager.LoadScene("Controls");
    }

    IEnumerator WaitTimeMainMenu()
    {
        yield return new WaitForSeconds(0.2f);
        SceneManager.LoadScene("MainMenu");
    }

    IEnumerator WaitTimeQuit()
    {
        yield return new WaitForSeconds(0.2f);
        PlayerPrefs.SetInt("Glowing", 0);
        Application.Quit();
    }

    IEnumerator WaitTimeGameplay()
    {
        yield return new WaitForSeconds(0.2f);
        SceneManager.LoadScene("Gameplay");
    }

    IEnumerator WaitTimeFunRoom()
    {
        yield return new WaitForSeconds(0.2f);
        SceneManager.LoadScene("FunRoom");
    }
}
