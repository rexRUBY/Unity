using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTank : MonoBehaviour
{
    float x, y, z;
    float speed = 5;
    // Start is called before the first frame update
    void Start()
    {
        x = 0;
        y = 0;
        z = 0;
    }

    // Update is called once per frame
    void Update()
    {
        x = Input.GetAxis("Horizontal") * Time.deltaTime * speed;
        z = Input.GetAxis("Vertical") * Time.deltaTime * speed;
        y = Input.GetAxis("Jump") * Time.deltaTime * speed;  //점프는 스페이스바, Rigidbody로 중력을 주어야 함.
        transform.Translate(x, y, z);
    }
}
