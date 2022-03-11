using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//컴포넌트 불러오기
public class Frame : MonoBehaviour  //MonoBehaviour를 상속받음 -> 컴포넌트 구조
{
    float x;
    float y;
    float z;
    int cnt;

    void Start()
    {
        x = 0;
        y = 0;
        z = 0;
        cnt = 0;
    }

     void Update() //매 프래임마다 할 일
    {
        cnt++;
        if (Time.time <=1) //프레임의 속도를 구하기 위함
            print(cnt);

        z = Input.GetAxis("Vertical")*Time.deltaTime; //Time.delaTime 은 한 프레임의 길이, 프레임은 가변적임
                                                      //성능에 상관없이 공정한 속도를 내기 위함            
        transform.Translate(x, y, z);

    }
}
