using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public Text timerTxt;
    public GameObject panelL;
    public static float time;  //����Ŭ���� �ν��Ͻ� ����

    void Start()
    {
        time= 30f;
    }

    void Update()
    {
        if (Mathf.Floor(time) <= 0) //Count 0�϶� ������ �Լ�, Mathf.Floor �۰ų� ���� ������ ��ȯ
        {
            panelL.SetActive(true);
            Time.timeScale = 0; //���� ����
        }
        else
        {
            time -= Time.deltaTime; //���� �帧
            timerTxt.text = Mathf.Floor(time).ToString(); //������Ʈ �̱� ������ Txt.text�� �� ��
        }
    }
}
