using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GamePlay : MonoBehaviour
{
    [Header("OBSTACLES")]
    public GameObject ObOne;
    public GameObject ObTwo;
    public GameObject ObThree;
    public GameObject ObFour;
    public GameObject ObFive;
    int Lev;

    [Header("LEVEL ONE TO THREE")]
    float TimeBtwSpawnsOne;
    float NewTime;
    float EndTimeOne;

    [Header("LEVEL ONE TO THREE")]
    float TimeBtwSpawnsTwo;
    float NewTimeTwo;
    float EndTimeTwo;

    [Header("AQUIRED")]
    Player Play;

    private void Start()
    {
        Play = FindObjectOfType<Player>();

        TimeBtwSpawnsOne = 0;
        NewTime = 2.5f;
        EndTimeOne = 1.2f;

        TimeBtwSpawnsTwo = 2f;
        NewTimeTwo = 2f;
        EndTimeTwo = 1.4f;
    }

    private void Update()
    {
        LevelOne();
        LevelTwo();
        LevelThree();
        LevelFour();
        LevelFive();
    }

    public void LevelOne()
    {
        if(Play.Points <= 25)
        {
            if(TimeBtwSpawnsOne <= 0)
            {
                Instantiate(ObOne, transform.position, Quaternion.identity);

                TimeBtwSpawnsOne = NewTime;
                if(TimeBtwSpawnsOne > EndTimeOne)
                {
                    NewTime -= 0.1f;
                }
            }
            else
            {
                TimeBtwSpawnsOne -= Time.deltaTime;
            }
        }
    }

    public void LevelTwo()
    {
        if (Play.Points > 25 && Play.Points <= 50)
        {
            if (TimeBtwSpawnsOne <= 0)
            {

                int Lev = Random.Range(1, 3);

                if (Lev == 1)
                {
                    Instantiate(ObTwo, transform.position, Quaternion.identity);
                }
                else if(Lev == 2)
                {
                    Instantiate(ObOne, transform.position, Quaternion.identity);
                }

                TimeBtwSpawnsOne = NewTime;
                if (TimeBtwSpawnsOne > EndTimeOne)
                {
                    NewTime -= 0.1f;
                }
            }
            else
            {
                TimeBtwSpawnsOne -= Time.deltaTime;
            }
        }
    }

    public void LevelThree()
    {
        if (Play.Points > 50 && Play.Points <= 80)
        {
            if (TimeBtwSpawnsOne <= 0)
            {
                Lev = Random.Range(1, 4);

                if (Lev == 1)
                {
                    Instantiate(ObThree, transform.position, Quaternion.identity);
                }
                else if(Lev == 2)
                {
                    Instantiate(ObTwo, transform.position, Quaternion.identity);
                }
                else if (Lev == 3)
                {
                    Instantiate(ObOne, transform.position, Quaternion.identity);
                }

                TimeBtwSpawnsOne = NewTime;
                if (TimeBtwSpawnsOne > EndTimeOne)
                {
                    NewTime -= 0.1f;
                }
            }
            else
            {
                TimeBtwSpawnsOne -= Time.deltaTime;
            }
        }
    }

    public void LevelFour()
    {
        if (Play.Points > 80 && Play.Points <= 120)
        {
            if (TimeBtwSpawnsTwo <= 0)
            {
                Lev = Random.Range(1, 5);
                if (Lev == 1)
                {
                    Instantiate(ObThree, transform.position, Quaternion.identity);
                }
                else if (Lev == 2)
                {
                    Instantiate(ObTwo, transform.position, Quaternion.identity);
                }
                else if (Lev == 3)
                {
                    Instantiate(ObOne, transform.position, Quaternion.identity);
                }
                else if (Lev == 4)
                {
                    Instantiate(ObFour, transform.position, Quaternion.identity);
                }

                TimeBtwSpawnsTwo = NewTimeTwo;
                if (TimeBtwSpawnsTwo > EndTimeTwo)
                {
                    NewTimeTwo -= 0.1f;
                }
            }
            else
            {
                TimeBtwSpawnsTwo-= Time.deltaTime;
            }
        }
    }

    public void LevelFive()
    {
        if (Play.Points > 120)
        {
            if (TimeBtwSpawnsTwo <= 0)
            {

                Lev = Random.Range(1, 6);
                if (Lev == 1)
                {
                    Instantiate(ObThree, transform.position, Quaternion.identity);
                }
                else if (Lev == 2)
                {
                    Instantiate(ObTwo, transform.position, Quaternion.identity);
                }
                else if (Lev == 3)
                {
                    Instantiate(ObOne, transform.position, Quaternion.identity);
                }
                else if (Lev == 4)
                {
                    Instantiate(ObFour, transform.position, Quaternion.identity);
                }
                else if(Lev == 5)
                {
                    Instantiate(ObFive, transform.position, Quaternion.identity);
                }

                TimeBtwSpawnsTwo = NewTimeTwo;
                if (TimeBtwSpawnsTwo > EndTimeTwo)
                {
                    NewTimeTwo -= 0.1f;
                }
            }
            else
            {
                TimeBtwSpawnsTwo -= Time.deltaTime;
            }
        }
    }
}
