using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ManagerSkins : MonoBehaviour
{
    public GameObject prefabButton;
    public Transform father;
    public PlayerConfig playerConfig;
    public PlayerData playerData;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < playerData.skins.Length; i++)
        {
           ButtonSkin bSkin =  Instantiate(prefabButton, father).GetComponent<ButtonSkin>();
            bSkin.managerSkins = GetComponent<ManagerSkins>();
            bSkin.GetComponent<Image>().color = playerData.colors[i];
        }
        if (!PlayerPrefs.HasKey("Skin"))
            PlayerPrefs.SetInt("Skin", 0);
        SetSkin(PlayerPrefs.GetInt("Skin"));

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetSkin(int x)
    {
        playerConfig.SetSkin(x);

        foreach (Transform item in father)
        {
            item.GetChild(0).GetChild(0).gameObject.SetActive(false);
        }

        father.GetChild(x).GetChild(0).GetChild(0).gameObject.SetActive(true);

        PlayerPrefs.SetInt("Skin", x);
    }
}
