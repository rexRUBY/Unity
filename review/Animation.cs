using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnim : MonoBehaviour
{   
    //Legacy
    float x;
    float z;
    Animation anim;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animation>();
    }

    // Update is called once per frame
    void Update()
    {
        z = Input.GetAxis("Vertical");
        x = Input.GetAxis("Horizontal");
        Vector3 v = transform.forward * z + transform.right * x; //벡터3의 좌표는 절대좌표 transform의 좌표는 상대좌표

        transform.Translate(v.normalized * Time.deltaTime); //사선으로 갈 때 위치 정규화

        if (z > 0.1f)
        {
            anim.CrossFade("WalkF", 0.3f);
        }
        else if (z < -0.1f)
        {
            anim.CrossFade("WalkB", 0.3f);
        }
        else if (x > 0.1)
        {
            anim.CrossFade("WalkR", 0.3f);
        }
        else if (x < -0.1)
        {
            anim.CrossFade("WalkL", 0.3f);
        }
        else
        {
            anim.CrossFade("Idle", 0.3f);
        }
    }
}
