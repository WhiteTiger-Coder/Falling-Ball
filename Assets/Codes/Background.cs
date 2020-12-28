using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background : MonoBehaviour
{



    void Start()
    {
        
    }

    void Update()
    {
        
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        transform.position = new Vector2(gameObject.transform.position.x, gameObject.transform.position.y - 80);

    }




}
