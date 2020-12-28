using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Creater : MonoBehaviour
{
    int trapNumber;
    public Transform ball;
    public GameObject lastTrap, leftRock, rightRock;
    Timer timer;



    void Start()
    {
        timer = gameObject.AddComponent<Timer>();
        timer.TotalTime = 1;
        timer.TurnOn();
        FirstTrapCreate();
        SecondTrapCreate();
    }

    void Update()
    {
        if (timer.finished)
        {
            if (ball.transform.position.y - lastTrap.transform.position.y < 10)
            {
                TrapCreater();
            }
        }
    }


    void TrapCreater()
    {

        trapNumber = Random.Range(1, 3);

        switch (trapNumber)
        {
            case 1:
                /*
                Instantiate(leftRock, new Vector2(leftRock.transform.position.x, ball.transform.position.y - 15), leftRock.transform.rotation);
                Instantiate(leftRock, new Vector2(leftRock.transform.position.x, ball.transform.position.y - 20), leftRock.transform.rotation);
                Instantiate(rightRock, new Vector2(rightRock.transform.position.x, ball.transform.position.y - 25), rightRock.transform.rotation);
                Instantiate(leftRock, new Vector2(leftRock.transform.position.x, ball.transform.position.y - 30), leftRock.transform.rotation);
                lastTrap = (GameObject)Instantiate(leftRock, new Vector2(leftRock.transform.position.x, ball.transform.position.y - 35), leftRock.transform.rotation);
                */

                Instantiate(leftRock, new Vector2(leftRock.transform.position.x, lastTrap.transform.position.y - 5), leftRock.transform.rotation);
                Instantiate(leftRock, new Vector2(leftRock.transform.position.x, lastTrap.transform.position.y - 10), leftRock.transform.rotation);
                Instantiate(rightRock, new Vector2(rightRock.transform.position.x, lastTrap.transform.position.y - 15), rightRock.transform.rotation);
                Instantiate(leftRock, new Vector2(leftRock.transform.position.x, lastTrap.transform.position.y - 20), leftRock.transform.rotation);
                lastTrap = (GameObject)Instantiate(leftRock, new Vector2(leftRock.transform.position.x, lastTrap.transform.position.y - 25), leftRock.transform.rotation);

                break;
            case 2:
                /*
                Instantiate(rightRock, new Vector2(rightRock.transform.position.x, ball.transform.position.y - 15), rightRock.transform.rotation);
                Instantiate(leftRock, new Vector2(leftRock.transform.position.x, ball.transform.position.y - 20), leftRock.transform.rotation);
                Instantiate(leftRock, new Vector2(leftRock.transform.position.x, ball.transform.position.y - 25), leftRock.transform.rotation);
                lastTrap = (GameObject)Instantiate(rightRock, new Vector2(rightRock.transform.position.x, ball.transform.position.y - 30), rightRock.transform.rotation);
                */

                Instantiate(rightRock, new Vector2(rightRock.transform.position.x, lastTrap.transform.position.y - 5), rightRock.transform.rotation);
                Instantiate(leftRock, new Vector2(leftRock.transform.position.x, lastTrap.transform.position.y - 10), leftRock.transform.rotation);
                Instantiate(leftRock, new Vector2(leftRock.transform.position.x, lastTrap.transform.position.y - 15), leftRock.transform.rotation);
                lastTrap = (GameObject)Instantiate(rightRock, new Vector2(rightRock.transform.position.x, lastTrap.transform.position.y - 20), rightRock.transform.rotation);

                break;

        }
    }

    void FirstTrapCreate()
    {

        trapNumber = Random.Range(1, 3);

        switch (trapNumber)
        {
            case 1:

                Instantiate(leftRock, new Vector2(leftRock.transform.position.x, ball.transform.position.y - 5), leftRock.transform.rotation);
                break;
            case 2:
                Instantiate(rightRock, new Vector2(rightRock.transform.position.x, ball.transform.position.y - 5), rightRock.transform.rotation);
                break;

        }
    }

    void SecondTrapCreate()
    {

        trapNumber = Random.Range(1, 3);

        switch (trapNumber)
        {
            case 1:

                Instantiate(leftRock, new Vector2(leftRock.transform.position.x, ball.transform.position.y - 10), leftRock.transform.rotation);
                lastTrap =(GameObject)Instantiate(leftRock, new Vector2(leftRock.transform.position.x, ball.transform.position.y - 15), leftRock.transform.rotation);

                break;
            case 2:
                Instantiate(rightRock, new Vector2(rightRock.transform.position.x, ball.transform.position.y - 5), rightRock.transform.rotation);
                lastTrap = (GameObject)Instantiate(rightRock, new Vector2(rightRock.transform.position.x, ball.transform.position.y - 5), rightRock.transform.rotation);

                break;

        }
    }



}
