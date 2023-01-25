using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class PauseGame : MonoBehaviour
{
    [Header("TEXT")]
    public TextMeshProUGUI Text;

    [Header("PAUSE MENU")]
    public GameObject PauseMenu;
    [HideInInspector]
    public bool IsPaused;

    private void Start()
    {
        PauseMenu.SetActive(false);
        IsPaused = false;
    }

    private void Update()
    {
        HighScoreText();
    }

    public void PauseAndResume()
    {
        if (IsPaused == true)
        {
            PauseMenu.SetActive(false);
            Time.timeScale = 1f;
            IsPaused = false;
        }
        else if (IsPaused == false)
        {
            PauseMenu.SetActive(true);
            Time.timeScale = 0f;
            IsPaused = true;
        }
    }

    public void HighScoreText()
    {
        Text.text = "HIGH SCORE: " + PlayerPrefs.GetInt("PlayerScore").ToString();
    }

    public void MustMainMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("MainMenu");
    }

    public void MustRestart()
    {
        Time.timeScale = 1f;
        PauseMenu.SetActive(false);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
