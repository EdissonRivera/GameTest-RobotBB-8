using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ManagerScene : MonoBehaviour
{
    public GameObject Score;
    internal bool gameOver;

    public void ChangeScene(int x)
    {
        SceneManager.LoadScene(x);
    }

    public void ExitGame()
    {
        Application.Quit();
    }

    public void ValidateGame()
    {
        if (gameOver)
            SceneManager.LoadScene(0);
        else
            Score.SetActive(false);



    }


}
