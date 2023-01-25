using UnityEngine.Audio;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    [Header("PLAYER STATS")]
    [HideInInspector]
    public int Points;
    [HideInInspector]
    public int HighScore;
    bool StartGame;
    float TimeTillStart;

    [Header("PLAYER MOVEMENT")]
    float Jump;
    float RotationSpeed;
    float RotationAxis;

    [Header("AQUIRED COMPONENTS")]
    public Color[] PlayersColor;
    public GameObject MoveParticles;
    public GameObject DeathParticles;
    PauseGame PG;
    SpriteRenderer Sp;
    ScoreManager SM;
    Rigidbody2D Rb;

    [Header("SOUND EFFECTS")]
    AudioSource JumpSFX;

    public void Start()
    {
        PG = FindObjectOfType<PauseGame>();
        Rb = GetComponent<Rigidbody2D>();
        Sp = GetComponent<SpriteRenderer>();
        SM = FindObjectOfType<ScoreManager>();
        JumpSFX = GetComponent<AudioSource>();
        ColorManager();

        StartGame = false;
        Rb.gravityScale = 0f;
        TimeTillStart = 1.5f;

        Points = 0;

        Jump = 0f;
        RotationSpeed = 160f;
    }

    public void Update()
    {
        StartMyGame();
        Jumping();
        Rotation();
        RestartScene();
        MainMenuScene();
        QuickPause();
        QuitGame();
    }

    public void StartMyGame()
    {
        if (TimeTillStart <= 0 && StartGame == false)
        {
            Rb.gravityScale = 2.5f;
            Jump = 8f;
            TimeTillStart = -5f;
            StartGame = true;
        }
        else if(StartGame == false)
        {
            TimeTillStart -= Time.deltaTime;
        }
    }

    public void Jumping()
    {
        if (PG.IsPaused == false)
        {
            if (Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.W) || Input.GetMouseButtonDown(0))
            {
                JumpSFX.Play();
                Rb.velocity = new Vector2(0f, Jump);
                GameObject A = Instantiate(MoveParticles, transform.position, MoveParticles.transform.rotation);
                Destroy(A, 1f);
            }
        }
    }

    public void Rotation()
    {
        RotationAxis += RotationSpeed * Time.deltaTime;
        transform.rotation = Quaternion.Euler(0f, 0f, RotationAxis);
    }

    public void RestartScene()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene("Gameplay");
        }
    }

    public void MainMenuScene()
    {
        if(Input.GetKeyDown(KeyCode.M))
        {
            SceneManager.LoadScene("MainMenu");
        }
    }

    public void QuitGame()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            PlayerPrefs.SetInt("Glowing", 0);
            Application.Quit();
        }
    }

    public void QuickPause()
    {
        if(Input.GetKeyDown(KeyCode.P))
        {
            PG.PauseAndResume();
        }
    }

    public void ColorManager()
    {
        if(PlayerPrefs.GetInt("PlayerColor") == 1)
        {
            Sp.color = PlayersColor[1];
        }
        else if (PlayerPrefs.GetInt("PlayerColor") == 2)
        {
            Sp.color = PlayersColor[2];
        }
        else if (PlayerPrefs.GetInt("PlayerColor") == 3)
        {
            Sp.color = PlayersColor[3];
        }
        else if (PlayerPrefs.GetInt("PlayerColor") == 4)
        {
            Sp.color = PlayersColor[4];
        }
        else if (PlayerPrefs.GetInt("PlayerColor") == 5)
        {
            Sp.color = PlayersColor[5];
        }
        else if (PlayerPrefs.GetInt("PlayerColor") == 6)
        {
            Sp.color = PlayersColor[6];
        }
        else if (PlayerPrefs.GetInt("PlayerColor") == 7)
        {
            Sp.color = PlayersColor[7];
        }
        else if (PlayerPrefs.GetInt("PlayerColor") == 8)
        {
            Sp.color = PlayersColor[8];
        }
        else if (PlayerPrefs.GetInt("PlayerColor") == 9)
        {
            Sp.color = PlayersColor[9];
        }
        else if (PlayerPrefs.GetInt("PlayerColor") == 10)
        {
            Sp.color = PlayersColor[10];
        }
        else if(PlayerPrefs.GetInt("PlayerColor") == 0)
        {
            Sp.color = PlayersColor[0];
        }
    }

    public void HealthCheck()
    {
        SM.GameScore();
        GameObject A = Instantiate(DeathParticles, transform.position, Quaternion.identity);
        Destroy(gameObject);
        Destroy(A, 2f);
    }
}
