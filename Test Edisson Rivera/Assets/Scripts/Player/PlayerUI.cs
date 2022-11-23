using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PlayerUI : MonoBehaviour
{
    [SerializeField] internal Image imgHealth;
    [SerializeField] internal Image imgFuel;
    [SerializeField] internal Text  textScore;
    [SerializeField] internal Text textTime;
    [SerializeField] GameObject pause;
    [SerializeField] internal GameObject tableScores;
    internal bool menu;

    public void MenuChange()
    {
        if (menu)
        {
            menu = false;
            pause.SetActive(true);
            Cursor.lockState = CursorLockMode.None;

        }
        else
        {
            menu=true;
            pause.SetActive(false);
            Cursor.lockState = CursorLockMode.Locked;

        }
    }
}
