﻿using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    public TextMeshProUGUI timer;
    private float timeInSec;
   

    void Start()
    {
        timeInSec = 120f;
    }

  
    void Update()
    {
        timeInSec -= Time.deltaTime;

        float minutes = Mathf.FloorToInt(timeInSec / 60);
        float seconds = Mathf.FloorToInt(timeInSec % 60);

        if (timeInSec > 0)
        {
            timer.text = string.Format("{0:00}:{1:00}", minutes, seconds);
        }
        else
        {
            Debug.Log("Stop Game");
        }
    }
}
