using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstaclesTwo : MonoBehaviour
{
    [Header("GAME STATS")]
    float Speed;

    [Header("OBSTACLES")]
    public GameObject Up;
    public GameObject Down;
    public GameObject Middle;

    [Header("COLOUR")]
    Animator Anim;
    Player Play;
    public SpriteRenderer One;
    public SpriteRenderer Two;
    public SpriteRenderer Three;
    public Color[] Colors;
    int UpCol;
    int DownCol;
    int MiddleCol;

    private void Start()
    {
        Play = FindObjectOfType<Player>();
        Anim = GameObject.FindGameObjectWithTag("LiveScore").GetComponent<Animator>();

        Speed = 6;

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

        if (transform.position.x <= -25)
        {
            Destroy(gameObject);
        }
    }


    public void ObjectColor()
    {
        UpCol = Random.Range(0, Colors.Length);
        DownCol = Random.Range(0, Colors.Length);
        MiddleCol = Random.Range(0, Colors.Length);

        if (DownCol == UpCol || DownCol == MiddleCol)
        {
            DownCol = Random.Range(0, Colors.Length);
        }

        if (MiddleCol == DownCol || MiddleCol == UpCol)
        {
            MiddleCol = Random.Range(0, Colors.Length);
        }

        One.color = Colors[UpCol];
        Two.color = Colors[DownCol];
        Three.color = Colors[MiddleCol];
    }
}
