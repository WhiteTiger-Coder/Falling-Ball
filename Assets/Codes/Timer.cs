using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    float totalTime = 0;
    float timePassed = 0;

    bool isWorking = false;
    bool started = false;

    /// <summary>
    /// Set the total time for the timer.
    /// </summary>
    public float TotalTime
    {
        set
        {
            if (!isWorking)
            {
                totalTime = value;
            }
        }
    }

    /// <summary>
    /// Start the timer.
    /// </summary>
    public void TurnOn()
    {
        if (totalTime > 0)
        {
            isWorking = true;
            started = true;
            timePassed = 0;
        }
    }

    /// <summary>
    /// Learn that if countdown is finished or not.
    /// </summary>
    public bool finished
    {
        get
        {
            return started && !isWorking;
        }
    }

    void Update()
    {
        if (isWorking)
        {
            timePassed += Time.deltaTime;
            if (timePassed >= totalTime)
            {
                isWorking = false;
            }
        }
    }
}