using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonSkin : MonoBehaviour
{
    public ManagerSkins managerSkins;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetSkin()
    {
        int x = transform.GetSiblingIndex();
        managerSkins.SetSkin(x);
    }
}
