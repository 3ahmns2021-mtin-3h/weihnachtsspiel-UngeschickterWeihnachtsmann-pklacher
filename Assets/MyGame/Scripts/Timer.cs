using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    public float timeInSec;
    // Start is called before the first frame update
    void Start()
    {
        timeInSec = 60f;
    }

    // Update is called once per frame
    void Update()
    {
        timeInSec -= Time.deltaTime;

        float minutes = Mathf.FloorToInt(timeInSec / 60);
        float seconds = Mathf.FloorToInt(timeInSec % 60);
    }
}
