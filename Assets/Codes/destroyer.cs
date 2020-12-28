using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyer : MonoBehaviour
{
    [SerializeField]
    GameObject ball;
    [SerializeField]
    


    void Start()
    {
        ball = GameObject.FindWithTag("ball");
    }

    void Update()
    {

       
        if ((gameObject.transform.position.y - ball.transform.position.y) > 3)
        {
            Destroy(gameObject);
        }
       

    }
}
