using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClockManager : MonoBehaviour
{

    public float transDuration = 1.0f;

    public GameObject hourHand, minuteHand, secondHand;


    private void updateTime()
    {
        var currTime = DateTime.Now;

        Quaternion hourTarget = Quaternion.Euler(currTime.Hour / 12.0f * 360.0f , 0, 0);
        hourHand.transform.rotation = hourTarget;


        Quaternion minuteTarget = Quaternion.Euler(currTime.Minute / 60.0f * 360.0f , 0, 0);
        minuteHand.transform.rotation = minuteTarget;

        Quaternion secondTarget = Quaternion.Euler(currTime.Second / 60.0f * 360.0f , 0, 0);
        secondHand.transform.rotation = secondTarget;

     
    }

    // Start is called before the first frame update
    void Start()
    {
        updateTime();

    }

    // Update is called once per frame
    void Update()
    {
        if (Time.frameCount % 20 == 0)
        {

            updateTime();
        }
    }
}
