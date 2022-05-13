using UnityEngine;
using System.Collections;

public class Paddle : MonoBehaviour
{
    float paddleSpeed = 1f;    
    void Update()
    {
        float xPos = transform.position.x + (Input.GetAxis("Horizontal") * paddleSpeed);        //transform.position.x 나의 위치
        transform.position = new Vector3(Mathf.Clamp(xPos, -5.5f, 5.5f), -9f, 0f); ;            //Mathf.Clamp(변수명 , 최솟값, 최댓값) 최솟값~최댓값 사이에서만 이동한다.
    }
}
