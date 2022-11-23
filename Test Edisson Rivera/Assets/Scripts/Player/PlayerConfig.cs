using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerConfig : MonoBehaviour
{
    public MeshRenderer[] meshPlayerBody;
    public PlayerData playerData;
    public bool menu;
    void Start()
    {
      if(menu)
            Cursor.lockState = CursorLockMode.None;
        SetSkin(PlayerPrefs.GetInt("Skin"));
    }
    public void SetSkin(int x)
    {
        foreach (MeshRenderer item in meshPlayerBody)
        {
            item.material = playerData.skins[x];
        }
    }

    private void Update()
    {
        if (menu)
            transform.Rotate(0, 0.25f, 0);
    }
}
