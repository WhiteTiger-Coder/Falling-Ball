using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingObstacle : MonoBehaviour
{

    public Rigidbody2D rb;
    public float velocityX;
    public bool left;
    public string type;
    Timer timer;


    // Start is called before the first frame update
    void Start()
    {


        rb = GetComponent<Rigidbody2D>();

        switch(type){

            case "laser":

                timer = gameObject.AddComponent<Timer>();
                timer.TotalTime = 5/velocityX+0.1f;
                timer.TurnOn();

                if (gameObject.transform.position.x < 0)
                {
                    rb.velocity = new Vector2(velocityX, 0);
                }
                else
                {
                    rb.velocity = new Vector2(-velocityX, 0);
                }
                break;
            case "ufo":
                if (left)
                {
                    velocityX = Random.Range(0.5f, 1.5f);
                    rb.velocity = new Vector2(velocityX, 0);
                }
                else
                {
                    velocityX = Random.Range(-0.5f, -1.5f);
                    rb.velocity = new Vector2(velocityX, 0);
                }
                break;
        }      

    }

    void Update()
    {
        if(type == "laser")
        {
            if (timer.finished)
            {
                Destroy(gameObject);
            }
        }
    }

}
