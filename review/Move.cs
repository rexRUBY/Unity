using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    // 탱크의 초기 위치
    float x;
    float y;
    float z;
    float r;
    // 시작 하자마자 할 일
    void Start()
    {
        x = 0;
        y = 0;
        z = 0;
    }

    // 매번(모든 프레임마다) 할 일
    void Update()
    {
        // 입력 방향키로 움직인다.
        // z가 앞뒤방향(수직)으로 움직임, 앞쪽 방향키값은 1, 뒷쪽은 -1
        z = Input.GetAxis("Vertical") * 0.1f;
        transform.Translate(x, y, z);

        //마우스를 x축으로 드래그 하면 방향 바뀜
        r = Input.GetAxis("Mouse X");
        transform.Rotate(0, r, 0);

        //Debug.Log(z); 확인하고싶은 z(변수)의 값
    }
}
