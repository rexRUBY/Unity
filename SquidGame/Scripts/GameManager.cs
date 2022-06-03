using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Singleton...
public class GameManager : MonoBehaviour
{
    public static GameManager instance; //클래스 내 모든 변수 및 함수 대상
    
    public static GameManager Instance
    {
        get { return instance; }
    }

    //게임 내에서 유지하려고 하는 시간
    public float time=30f;
    //게임 내에서 유지하려고 하는 속도
    public float speed = 0.3f;

    private void Awake()  //Awake는 스크립트에서 가장 먼저 실행됨
    {
        if (instance) //instance가 내가 아니라면 이미 instance가 하나 존재하고 있다는 의미
        {
            Destroy(gameObject); //둘 이상 존재하면 안되는 객체이니 방금 AWake된 자신을 삭제
        }
        else if (!instance) //instance가 시스템상에 존재하고 있지 않을때
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }

    public void timeUp()
    {
        time += 3f;
        Timer.time += 3;
    }

    public void timeDown()
    {
        time -= 3f;
        Timer.time -= 3;
    }
}