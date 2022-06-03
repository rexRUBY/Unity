using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public Text timerTxt;
    public GameObject panelL;
    public static float time;  //전역클래스 인스턴스 변수

    void Start()
    {
        time= 30f;
    }

    void Update()
    {
        if (Mathf.Floor(time) <= 0) //Count 0일때 동작할 함수, Mathf.Floor 작거나 같은 정수값 반환
        {
            panelL.SetActive(true);
            Time.timeScale = 0; //게임 종료
        }
        else
        {
            time -= Time.deltaTime; //초의 흐름
            timerTxt.text = Mathf.Floor(time).ToString(); //컴포넌트 이기 때문에 Txt.text를 해 줌
        }
    }
}
