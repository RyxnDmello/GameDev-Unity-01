using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstaclesFour : MonoBehaviour
{
    [Header("GAME STATS")]
    float Speed;

    [Header("OBSTACLES")]
    public GameObject A1;
    public GameObject A2;
    public GameObject A3;
    public GameObject A4;
    public GameObject A5;

    [Header("COLOUR")]
    Animator Anim;
    Player Play;
    public SpriteRenderer One;
    public SpriteRenderer Two;
    public SpriteRenderer Three;
    public SpriteRenderer Four;
    public SpriteRenderer Five;
    public Color[] Colors;
    int AA1;
    int AA2;
    int AA3;
    int AA4;
    int AA5;

    private void Start()
    {
        Play = FindObjectOfType<Player>();
        Anim = GameObject.FindGameObjectWithTag("LiveScore").GetComponent<Animator>();

        Speed = 6f;

        ObjectColor();
    }

    private void Update()
    {
        Movement();
    }

    private void OnTriggerEnter2D(Collider2D Other)
    {
        if (Other.CompareTag("Player"))
        {
            Play.Points++;
            Anim.SetTrigger("NewPoint");
        }

        if (Other.CompareTag("LeftWall"))
        {
            Destroy(gameObject);
        }
    }

    public void Movement()
    {
        transform.Translate(Vector2.left * Speed * Time.deltaTime);

        if (transform.position.x <= -28)
        {
            Destroy(gameObject);
        }
    }

    public void ObjectColor()
    {
        AA1 = Random.Range(0, Colors.Length);
        AA2 = Random.Range(0, Colors.Length);
        AA3 = Random.Range(0, Colors.Length);
        AA4 = Random.Range(0, Colors.Length);
        AA5 = Random.Range(0, Colors.Length);

        One.color = Colors[AA1];
        Two.color = Colors[AA2];
        Three.color = Colors[AA3];
        Four.color = Colors[AA4];
        Five.color = Colors[AA5];
    }
}
