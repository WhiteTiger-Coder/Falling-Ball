using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Taret : MonoBehaviour
{

    public GameObject laser;
    public bool left;
    Timer timer;

    // Start is called before the first frame update
    void Start()
    {
        if (left)
        {
            Instantiate(laser, new Vector2(gameObject.transform.position.x + 0.75f, gameObject.transform.position.y), laser.transform.rotation);
        }
        else
        {
            Instantiate(laser, new Vector2(gameObject.transform.position.x - 0.75f, gameObject.transform.position.y), laser.transform.rotation);
        }
        timer = gameObject.AddComponent<Timer>();
        timer.TotalTime = 4;
        timer.TurnOn();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer.finished)
        {
            if (left)
            {
                Instantiate(laser, new Vector2(gameObject.transform.position.x + 0.75f, gameObject.transform.position.y), laser.transform.rotation);
            }
            else
            {
                Instantiate(laser, new Vector2(gameObject.transform.position.x - 0.75f, gameObject.transform.position.y), laser.transform.rotation);
            }
            timer.TurnOn();
        }
    }
}
