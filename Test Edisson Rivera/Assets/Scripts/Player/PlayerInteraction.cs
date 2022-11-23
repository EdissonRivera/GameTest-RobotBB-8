using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteraction : MonoBehaviour
{
    //public Score score;
    [SerializeField] int coint;
    [SerializeField] float health;
    [SerializeField] internal int score; 
    PlayerUI playerUI;
    PlayerManager playerManager;
    public GameObject objective;
    private void Start()
    {
        playerUI = GetComponent<PlayerUI>();
        playerManager = GetComponent<PlayerManager>();  
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Coin")
        {
            score = score + 10;
            SetUI();
            Destroy(other.gameObject);
        }

        if (other.tag == "Bullet")
        {
            if(health >= 0)
            {

            health = health -10;
            playerUI.imgHealth.fillAmount = health / 100;
            if (health <= 0)
            {
                GetComponent<Rigidbody>().useGravity = false;
                GameObject.FindGameObjectWithTag("Time").SetActive(false);
                playerManager.GameOver();
            }
            }

        }


        if (other.tag == "Cofre")
        {
            score = score + 100;
            objective.SetActive(false);
            Destroy(other.gameObject);
            SetUI();
            GetComponent<Rigidbody>().useGravity = false;
            GameObject.FindGameObjectWithTag("Time").SetActive(false);
            playerManager.GameOver();
        }

        if (other.tag == "Death")
        {
            GetComponent<Rigidbody>().useGravity = false;
            GameObject.FindGameObjectWithTag("Time").SetActive(false);
            playerManager.GameOver();
        }

        if (other.tag == "ActiveEnemy")
        {
            foreach (Transform item in other.transform)
            {
                item.gameObject.SetActive(true);
            }
        }

    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "ActiveEnemy")
        {
            foreach (Transform item in other.transform)
            {
                item.gameObject.SetActive(false);
            }
        }
    }


    void SetUI()
    {
        playerUI.textScore.text = "SCORE: " + score.ToString();
    }

    public float GetScore()
    {
        //score.myDict.Add("Five", coint);
        //score.data();
        //score.AddData("pendeji");
        int scoreData = score;

        return scoreData;
    }

}
