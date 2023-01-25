using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleThree : MonoBehaviour
{
    [Header("GAME STATS")]
    float Speed;
    int Flip;

    [Header("OBSTACLES")]
    public GameObject A1;
    public GameObject A2;
    public GameObject A3;
    public GameObject A4;
    public GameObject A5;
    public GameObject A6;
    public GameObject A7;

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
    public Color[] Colors;
    int AA1;
    int AA2;
    int AA3;
    int AA4;
    int AA5;
    int AA6;
    int AA7;

    private void Start()
    {
        Anim = GameObject.FindGameObjectWithTag("LiveScore").GetComponent<Animator>();
        Play = FindObjectOfType<Player>();
        Flips();

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

    public void Flips()
    {
        Flip = Random.Range(1, 3);
        if (Flip == 2)
        {
            transform.rotation = (Quaternion.Euler(0f, 180f, 0f));
            Speed = -6f;
        }
        else if(Flip == 1)
        {
            Speed = 6f;
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

        One.color = Colors[AA1];
        Two.color = Colors[AA2];
        Three.color = Colors[AA3];
        Four.color = Colors[AA4];
        Five.color = Colors[AA5];
        Six.color = Colors[AA6];
        Seven.color = Colors[AA7];
    }
}
