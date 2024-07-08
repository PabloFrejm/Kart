using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;
using UnityEngine.UI;
public class setTimerFootball : MonoBehaviour
{

    public TextMeshProUGUI textTimeGame, textTimeStartGame;
    public float currentTime;
    public Client GetClient;
    public float indexTime;
    public bool bTime;
    public Button btnStart;
    public CommandClient GetCommand;
    public float timeStart;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        textTimeGame.text = TimeSpan.FromSeconds(currentTime).ToString(@"h\:mm\:ss");
        textTimeStartGame.text = TimeSpan.FromSeconds(currentTime).ToString(@"h\:mm\:ss");
        if (currentTime > 0) { btnStart.interactable = true; } else { btnStart.interactable = false; }
        if (bTime) { TimeLow(); }

    }

    public void setTimePlus(float t)
    {
        currentTime += t * 60;
    }

    public void setTimeMinus(float t)
    {

        if (currentTime > 0) { currentTime -= t * 60; }
        if (currentTime < 600 && t == 10) { currentTime = 0; } else if (currentTime < 300 && t == 5) { currentTime = 0; }

    }

    public void TimeLow()
    {
        if (currentTime > 0) { currentTime -= Time.deltaTime; } else { ActEndTime(); }

    }
    public void ActEndTime()
    {

        GetCommand.SendCommandStopFootBall();

    }

    public void SetBTime(bool b)
    {
        bTime = b;
    }

    public void GetTimeStart()
    {
        timeStart = currentTime;
    }

    public void SetTimeStart()
    {
        currentTime = timeStart;

    }
    public void clearTime()
    {
        timeStart = 0;  
        currentTime = 0;
    }
}

