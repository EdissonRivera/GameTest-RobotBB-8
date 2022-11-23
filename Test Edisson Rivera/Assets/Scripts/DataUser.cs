using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class DataUser : MonoBehaviour
{

    public InputField inputNick;
    public Text textWelcome;

    private void Start()
    {
        string nick = PlayerPrefs.GetString("NickName");
        textWelcome.text = "Welcome  " + nick;
    }

    public void SaveNick()
    {
        Debug.Log(inputNick.text);
        PlayerPrefs.SetString("NickName", inputNick.text);
        textWelcome.text = "Welcome " + inputNick.text;
    } 
}
