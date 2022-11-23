/*//////////////////////////////////////////////////////////////////////////////////////  
7/PROYECTO    :  TEST GAMEDEVELOPER#   AUTOR   : EDISSON RIVERA  DEVELOPER#           // 
////////////////////////////////////////////////////////////////////////////////////////   
//OBJETIVO    :   Conectar distintos scripts del player#                             ///
//////////////////////////////////////////////////////////////////////////////////////*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    
    PlayerInput input;
    PlayerMovement movement;
    PlayerInteraction interaction;

    ScoreDataBase scoreData;
    PlayerUI UI;
    ManagerScene scene;
    private void Start()
    {
        input = GetComponent<PlayerInput>();
        movement = GetComponent<PlayerMovement>();
        interaction = GetComponent<PlayerInteraction>();
        UI = GetComponent<PlayerUI>();
        scene = GameObject.FindGameObjectWithTag("Scene").GetComponent<ManagerScene>();
        scoreData = GameObject.FindGameObjectWithTag("DataBase").GetComponent<ScoreDataBase>();
    }

    private void Update()
    {
        movement.jump = input.jump;
        movement.InputDirectionX = input.InputDirectionX;
        movement.InputDirectionY = input.InputDirectionY;
    }


    public void GameOver()
    {
        scoreData.SetScore(PlayerPrefs.GetString("NickName"),(int)interaction.GetScore());
        UI.tableScores.SetActive(true);
        movement.enabled = false;
        Cursor.lockState = CursorLockMode.None;
        scene.gameOver = true;
        Invoke("menu", 30);
    }

    void menu()
    {
        scene.ChangeScene(0);

    }
}
