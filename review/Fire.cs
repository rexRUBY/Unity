using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour
{
    public GameObject firePosition; //인스펙터 창에서 조정 가능
    public GameObject bullet; //인스펙터 창에서 조정할 경우 초기화 하지 않아도 됨.
    public GameObject arrow;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0)) //0좌 1우 2휠
        {
            Object obj = Instantiate(bullet, firePosition.transform.position, firePosition.transform.rotation); //새로 생성할때 키워드 뭘,어디에, 어느각도
            Destroy(obj, 5.5f);
        }
        else if (Input.GetMouseButtonDown(1)) //0좌 1우 2휠
        {
            Object obj = Instantiate(arrow, firePosition.transform.position, firePosition.transform.rotation); //새로 생성할때 키워드 뭘,어디에, 어느각도
            Destroy(obj, 5.5f);
        }
    }
}
