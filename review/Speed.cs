using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//컴포넌트 불러오기
public class Speed : MonoBehaviour  //MonoBehaviour를 상속받음 -> 컴포넌트 구조
{
    float x;
    float y;
    float z;
    public float speed; //인스펙터 창에서 스피드를 조절할 수 있음 

    void Start()
    {
        x = 0;
        y = 0;
        z = 0;
    }

     void Update() //매 프래임마다 할 일
    {

        z = Input.GetAxis("Vertical")*Time.deltaTime; //Time.delaTime 은 한 프레임의 길이, 프레임은 가변적임
                                                      //성능에 상관없이 공정한 속도를 내기 위함            
        transform.Translate(x, y, z);

    }
}
