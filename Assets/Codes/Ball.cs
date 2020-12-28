using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;

public class Ball : MonoBehaviour {

    public float velocityX, velocityY;
    public GameObject gameOverPanel;
    public Rigidbody2D rb;


    void Start()
    {
        gameOverPanel.SetActive(false);
        rb = GetComponent<Rigidbody2D>();

        velocityY = 5;


        
    }

    void Update()
    {
        if(velocityY < 15)
        {
            velocityY += Time.deltaTime / 2;
        }


        if (Input.GetKey(KeyCode.A))
        {
            velocityX = -5;
        }else if (Input.GetKey(KeyCode.D))
        {
            velocityX = 5;
        }
        else
        {
            velocityX = 0;
        }




        rb.velocity = new Vector2(velocityX, -velocityY);

        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Trap")
        {

            gameOverPanel.SetActive(true);
            Time.timeScale = 0;
        }

        
    }


    public void GameRestart()
    {
        gameOverPanel.SetActive(false);
        gameObject.transform.position = new Vector3(0, 4, 0);
        velocityX = 0;
        velocityY = 5;
        Time.timeScale = 1;




    }


}
