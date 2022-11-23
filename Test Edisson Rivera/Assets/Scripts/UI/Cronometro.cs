using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using System;

public class Cronometro : MonoBehaviour
{
    public int timeInitial;
    public float speedTime;
    private float updateTime;
    public Text textCronometro;
    public bool gameOver;
    public PlayerManager playerManager;
    private void Start()
    {
        updateTime = timeInitial;
    }

    private void Update()
    {
        if (!gameOver)
        {
            updateTime = ActualizarFrames(speedTime, updateTime);
            textCronometro.text = "TIME: " + ConvertCaracters(updateTime);
            if (updateTime <= 0)
            {
                Debug.Log("GameOver");
                gameOver = true;
                playerManager.GameOver();
            }
        }
    }

    float ActualizarFrames(float speedTime, float updateTime)
    {
        float frames = speedTime * Time.deltaTime;
        updateTime += frames;
        return updateTime;
    }

    string ConvertCaracters(float a)
    {
        int minuto;
        minuto = (int)a / 60;
        int segundo;
        segundo = (int)a % 60;
        return minuto.ToString("00") + ":" + segundo.ToString("00");
    }
}
