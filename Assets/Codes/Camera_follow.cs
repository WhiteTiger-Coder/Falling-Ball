using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_follow : MonoBehaviour
{

    public Transform ball;

    void Start()
    {
        
        
    }

    void Update()
    {

        transform.position = new Vector3(transform.position.x, ball.transform.position.y-3.5f,transform.position.z);

        



    }

    


}
