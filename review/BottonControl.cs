using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonControl : MonoBehaviour
{
    //버튼의 기능들만 구현
    public void PauseClick() //pause누르면 할 일
    {
        Time.timeScale = 0;
    }

    public void PlayClick() //play 누르면 할 일
    {
        Time.timeScale = 1;
    }
}
