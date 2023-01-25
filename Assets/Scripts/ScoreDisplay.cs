using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreDisplay : MonoBehaviour
{
    public TextMeshProUGUI GameScore;

    Player Play;

    private void Start()
    {
        Play = FindObjectOfType<Player>();
    }

    private void Update()
    {
        if (Play.Points > 0)
        {
            GameScore.text = Play.Points.ToString();
        }
    }
}
