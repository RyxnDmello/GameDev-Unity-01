using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstaclesFive : MonoBehaviour
{
    [Header("GAME STATS")]
    float Speed;

    [Header("OBSTACLES")]
    public GameObject A1;
    public GameObject A2;
    public GameObject A3;
    public GameObject A4;
    public GameObject A5;
    public GameObject A6;
    public GameObject A7;
    public GameObject A8;
    public GameObject A9;
    public GameObject A10;

    [Header("COLOUR")]
    Player Play;
    Animator Anim;
    public SpriteRenderer One;
    public SpriteRenderer Two;
    public SpriteRenderer Three;
    public SpriteRenderer Four;
    public SpriteRenderer Five;
    public SpriteRenderer Six;
    public SpriteRenderer Seven;
    public SpriteRenderer Eight;
    public SpriteRenderer Nine;
    public SpriteRenderer Ten;

    public Color[] Colors;
    int AA1;
    int AA2;
    int AA3;
    int AA4;
    int AA5;
    int AA6;
    int AA7;
    int AA8;
    int AA9;
    int AA10;

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

    public void Movement()
    {
        transform.Translate(Vector2.left * Speed * Time.deltaTime);

        if (transform.position.x <= -35)
        {
            Destroy(gameObject);
        }
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

    public void ObjectColor()
    {
        AA1 = Random.Range(0, Colors.Length);
        AA2 = Random.Range(0, Colors.Length);
        AA3 = Random.Range(0, Colors.Length);
        AA4 = Random.Range(0, Colors.Length);
        AA5 = Random.Range(0, Colors.Length);
        AA6 = Random.Range(0, Colors.Length);
        AA7 = Random.Range(0, Colors.Length);
        AA8 = Random.Range(0, Colors.Length);
        AA9 = Random.Range(0, Colors.Length);
        AA10 = Random.Range(0, Colors.Length);

        One.color = Colors[AA1];
        Two.color = Colors[AA2];
        Three.color = Colors[AA3];
        Four.color = Colors[AA4];
        Five.color = Colors[AA5];
        Six.color = Colors[AA6];
        Seven.color = Colors[AA7];
        Eight.color = Colors[AA8];
        Nine.color = Colors[AA9];
        Ten.color = Colors[AA10];
    }
}
