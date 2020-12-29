using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Creater : MonoBehaviour
{
    int trapNumber,trapNumber1,trapNumber2;
    public GameObject lastTrap, leftRock, rightRock,ball,movingObstRight,movingObstLeft,leftTaret,rightTaret;
    Timer timer;



    void Start()
    {
        ball = GameObject.FindWithTag("ball");
        timer = gameObject.AddComponent<Timer>();
        timer.TotalTime = 1;
        timer.TurnOn();
        FirstTrapCreate();
        SecondTrapCreate();
        Time.timeScale = 1;

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

                Instantiate(leftRock, new Vector2(leftRock.transform.position.x, lastTrap.transform.position.y - 5), leftRock.transform.rotation);
                Instantiate(leftRock, new Vector2(leftRock.transform.position.x, lastTrap.transform.position.y - 10), leftRock.transform.rotation);
                Instantiate(rightRock, new Vector2(rightRock.transform.position.x, lastTrap.transform.position.y - 15), rightRock.transform.rotation);
                Instantiate(movingObstLeft, new Vector2(movingObstLeft.transform.position.x, lastTrap.transform.position.y - 20), movingObstLeft.transform.rotation);
                Instantiate(rightTaret, new Vector2(rightTaret.transform.position.x, lastTrap.transform.position.y - 25), rightTaret.transform.rotation);
                Instantiate(leftTaret, new Vector2(leftTaret.transform.position.x, lastTrap.transform.position.y - 30), leftTaret.transform.rotation);
                lastTrap = (GameObject)Instantiate(leftRock, new Vector2(leftRock.transform.position.x, lastTrap.transform.position.y - 35), leftRock.transform.rotation);

                break;
            case 2:
               
                Instantiate(rightRock, new Vector2(rightRock.transform.position.x, lastTrap.transform.position.y - 5), rightRock.transform.rotation);
                Instantiate(leftTaret, new Vector2(leftTaret.transform.position.x, lastTrap.transform.position.y - 15), leftTaret.transform.rotation);
                Instantiate(rightTaret, new Vector2(rightTaret.transform.position.x, lastTrap.transform.position.y - 20), rightTaret.transform.rotation);
                Instantiate(leftRock, new Vector2(leftRock.transform.position.x, lastTrap.transform.position.y - 25), leftRock.transform.rotation);
                Instantiate(leftRock, new Vector2(leftRock.transform.position.x, lastTrap.transform.position.y - 30), leftRock.transform.rotation);
                Instantiate(movingObstRight, new Vector2(movingObstRight.transform.position.x, lastTrap.transform.position.y - 35), movingObstRight.transform.rotation);
                lastTrap = (GameObject)Instantiate(rightRock, new Vector2(rightRock.transform.position.x, lastTrap.transform.position.y - 40), rightRock.transform.rotation);

                break;

        }
    }

    void FirstTrapCreate()
    {

        trapNumber1 = Random.Range(1, 3);

        switch (trapNumber1)
        {
            case 1:

                Instantiate(leftRock, new Vector2(leftRock.transform.position.x, ball.transform.position.y - 10), leftRock.transform.rotation);
                break;
            case 2:
                Instantiate(rightRock, new Vector2(rightRock.transform.position.x, ball.transform.position.y - 10), rightRock.transform.rotation);
                break;

        }
    }

    void SecondTrapCreate()
    {

        trapNumber2 = Random.Range(1, 3);

        switch (trapNumber2)
        {
            case 1:

                Instantiate(leftRock, new Vector2(leftRock.transform.position.x, ball.transform.position.y - 15), leftRock.transform.rotation);
                lastTrap =(GameObject)Instantiate(leftRock, new Vector2(leftRock.transform.position.x, ball.transform.position.y - 20), leftRock.transform.rotation);

                break;
            case 2:
                Instantiate(rightRock, new Vector2(rightRock.transform.position.x, ball.transform.position.y - 15), rightRock.transform.rotation);
                lastTrap = (GameObject)Instantiate(rightRock, new Vector2(rightRock.transform.position.x, ball.transform.position.y - 20), rightRock.transform.rotation);

                break;

        }
    }


    public void GameRestart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }



}
