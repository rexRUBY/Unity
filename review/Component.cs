using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//컴포넌트 불러오기
public class Move : MonoBehaviour  //MonoBehaviour를 상속받음 -> 컴포넌트 구조
{
    Transform tc;

    void Start()
    {
        tc = GetComponent<Transform>();
    }

     void Update()
    {
        tc.Translate(0, 0, 0.01f);
        //transform.Translate의 transform은 GetComponent<Transform>() 와 같은 뜻이다.
        // GetComponent<Transform>().Translate(0.0.01f);와 같은 뜻이지만 쓸때마다 클래스를 불러오기 때문에 성능상 좋지 않음.
    }
}
