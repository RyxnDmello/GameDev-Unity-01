using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstaclesOne : MonoBehaviour
{
    [Header("GAME STATS")]
    float Speed;

    [Header("OBSTACLES")]
    public GameObject Up;
    public GameObject Down;
    Vector2 UpPos;
    Vector2 DownPos;

    [Header("COLOUR")]
    public SpriteRenderer One;
    public SpriteRenderer Two;
    public Color[] Colors;
    int UpCol;
    int DownCol;

    [Header("AQUIRED")]
    Animator Anim;
    Player Play;
    
    private void Start()
    {
        Play = FindObjectOfType<Player>();
        Anim = GameObject.FindGameObjectWithTag("LiveScore").GetComponent<Animator>();

        Speed = 6f;

        ObjectColor();
        Position();
    }

    private void Update()
    {
        Movement();
    }

    private void OnTriggerEnter2D(Collider2D Other)
    {
        if(Other.CompareTag("Player"))
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

        if(transform.position.x <= -25)
        {
            Destroy(gameObject);
        }
    }

    public void Position()
    {
        UpPos.x = transform.position.x;
        UpPos.y = Random.Range(-2f, 5f);

        DownPos.x = transform.position.x;
        DownPos.y = UpPos.y - 2.85f;
      
        Up.transform.position = UpPos;
        Down.transform.position = DownPos;
    }

    public void ObjectColor()
    {
        UpCol = Random.Range(0, Colors.Length);
        DownCol = Random.Range(0, Colors.Length);

        if(DownCol == UpCol)
        {
            if(UpCol == Colors.Length - 1)
            {
                DownCol = Colors.Length - 2;
            }    
            else
            {
                DownCol = Colors.Length - 1;
            }
        }

        One.color = Colors[UpCol];
        Two.color = Colors[DownCol];
    }
}
