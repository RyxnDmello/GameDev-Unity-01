using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    [Header("OTHERS")]
    public GameObject Text1;
    public GameObject Text2;
    public GameObject Text3;

    [Header("TEXT")]
    public TextMeshProUGUI text;
    int ScoreVal;

    [Header("AQUIRED COMPONENTS")]
    PauseGame PG;
    Animator Anim;
    Animator Anim2;
    Player Play;

    private void Start()
    {
        PG = FindObjectOfType<PauseGame>();
        Anim = GameObject.FindGameObjectWithTag("BeatenText").GetComponent<Animator>();
        Anim2 = GameObject.FindGameObjectWithTag("HighScoreHolder").GetComponent<Animator>();
        Play = FindObjectOfType<Player>();
        ScoreVal = 0;
    }

    private void Update()
    {
        HighScoreDisplay();
        WhenPaused();
        GameScore();
    }

    public void WhenPaused()
    {
        if(PG.IsPaused == true)
        {
            Text1.SetActive(false);
            Text2.SetActive(false);
            Text3.SetActive(false);
        }

        if(PG.IsPaused == false)
        {
            Text1.SetActive(true);
            Text2.SetActive(true);
            Text3.SetActive(true);
        }
    }

    public void ResetScore()
    {
        PlayerPrefs.SetInt("PlayerScore", 0);
    }

    public void GameScore()
    {
        ScoreVal = Play.Points;
        if (ScoreVal > PlayerPrefs.GetInt("PlayerScore"))
        {
            Anim2.SetTrigger("NewHighScore");
            Anim.SetTrigger("HighScore");

            PlayerPrefs.SetInt("PlayerScore", ScoreVal);
        }
    }

    public void HighScoreDisplay()
    {
        if (ScoreVal > PlayerPrefs.GetInt("PlayerScore"))
        {
            text.text = Play.Points.ToString();
        }
        else
        {
            text.text = "HIGH SCORE: "+PlayerPrefs.GetInt("PlayerScore").ToString();
        }
    }
}
