using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    internal float InputDirectionX;
    internal float InputDirectionY;
    internal bool jump;
    internal PlayerUI playerUI;
    [SerializeField] internal WeaponManager WeaponManager;

    private void Start()
    {
        playerUI = GetComponent<PlayerUI>();
    }
    private void Update()
    {
        CheckInput();
    }
    void CheckInput()
    {
        InputDirectionX = Input.GetAxisRaw("Horizontal");
        InputDirectionY = Input.GetAxisRaw("Vertical");
        if (Input.GetButtonDown("Jump"))
        {
            jump = true;
        }
        else
        {
            jump = false;
        }
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            WeaponManager.SetWeapon(0);
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            WeaponManager.SetWeapon(1);
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            WeaponManager.SetWeapon(2);
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            playerUI.MenuChange();
        }
    }
}
