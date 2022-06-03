using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
    public GameObject BottonCV;

    public void OnClickNewGame()
    {
        BottonCV.SetActive(false);
    }

    public void OnclickQuit()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying=false;
#else
        Appliction.Quit();
#endif
    }
}
