using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;

public class Ball : MonoBehaviour {

    public float velocityX, velocityY;
    public GameObject gameOverPanel,background1,background2,menuPanel;
    public Rigidbody2D rb;
    


    void Start()
    {
        gameOverPanel.SetActive(false);
        menuPanel.SetActive(true);
        rb = GetComponent<Rigidbody2D>();

        Time.timeScale = 0;



    }

    void Update()
    {
        if(velocityY < 13)
        {
            velocityY += Time.deltaTime / 5;
        }


        if (Input.GetKey(KeyCode.A))
        {
            velocityX = -5;
          // transform.Rotate(0, 0, -1);
        }else if (Input.GetKey(KeyCode.D))
        {
            velocityX = 5;
           // transform.Rotate(0, 0, 1);
        }
        else
        {
            velocityX = 0;
        }

        transform.position = new Vector2(Mathf.Clamp(transform.position.x, -2.25f, 2.25f), transform.position.y);

        rb.velocity = new Vector2(velocityX, -velocityY);
        

        
    }

    private void FixedUpdate()
    {
        transform.Rotate(0, 0, -7);

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Trap")
        {

            gameOverPanel.SetActive(true);
            Time.timeScale = 0;
        }

        
    }

    public void ButtonStart()
    {
        velocityY = 5;
        menuPanel.SetActive(false);
        Time.timeScale = 1;
    }
}
