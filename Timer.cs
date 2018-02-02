using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{

    float gametimer;
    Text _timer;
    bool caunt;

    void Start()
    {
        _timer = GetComponent<Text>();
        var player1 = GameObject.Find("dango/Canvas/Timer").transform;
    }

    void FixedUpdate()
    {
        GameTimer();
    }

    /// <summary>
    ///タイムを刻む
    /// </summary>
    private void GameTimer()
    {
        int minute = 0;
        int second = 0;
        int microsecond = 0;
        if (!caunt)
        {
            gametimer += Time.deltaTime;
            if (gametimer > 3)
            {
                caunt = true;
                gametimer = 0;
                return;
            }
        }
        if (caunt)
        {
            gametimer += Time.deltaTime;
            minute = (int)gametimer / 60;
            second = (int)gametimer % 60;
            microsecond = (int)(gametimer * 1000) % 1000;
        }
        _timer.text = minute.ToString() + ":" + second.ToString("00") + "." + microsecond.ToString("000");
    }
}