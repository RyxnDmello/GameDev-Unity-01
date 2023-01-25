using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerEnd : MonoBehaviour
{
    Player Play;
    Animator Anim;
    float TimeBtwNextScene;
    int Check;

    private void Start()
    {
        Play = FindObjectOfType<Player>();
        Anim = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Animator>();

        TimeBtwNextScene = 2f;
        Check = 1;
    }

    private void OnTriggerEnter2D(Collider2D Other)
    {
        if(Other.CompareTag("Player"))
        {
            Check = 0;
            Play.HealthCheck();
            Anim.SetTrigger("CamShake");
        }

        if (Other.CompareTag("LeftWall"))
        {
            Destroy(gameObject);
        }
    }

    private void Update()
    {
        EndGame();
    }

    public void EndGame()
    {
        if (Check == 0)
        {
            if (TimeBtwNextScene <= 0)
            {
                SceneManager.LoadScene("GameOver");
            }
            else
            {
                TimeBtwNextScene -= Time.deltaTime;
            }
        }
    }
}
