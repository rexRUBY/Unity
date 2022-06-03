using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Anim : MonoBehaviour
{
    [SerializeField]
    private Animator anim;

    float x;
    float z;
    void start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        float moveX = Input.GetAxis("Horizontal");
        float moveZ = Input.GetAxis("Vertical");

        Vector3 moveVector = new Vector3(moveX, 0f, moveZ);
        anim.SetBool("isMove", moveVector.magnitude > 0);

        transform.Translate(new Vector3(moveX, 0f, moveZ).normalized * Time.deltaTime * 0.5f); //사선으로 갈 때 위치 정규화
    }
}
