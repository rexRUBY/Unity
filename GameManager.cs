using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject myPanel;

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.P))
        {
            myPanel.SetActive(true); //P키가 눌리면 마이 패널의 활성화 여부를 켜라 
        }
    }
}
