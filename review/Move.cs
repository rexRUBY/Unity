using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    // ��ũ�� �ʱ� ��ġ
    float x;
    float y;
    float z;
    float r;
    // ���� ���ڸ��� �� ��
    void Start()
    {
        x = 0;
        y = 0;
        z = 0;
    }

    // �Ź�(��� �����Ӹ���) �� ��
    void Update()
    {
        // �Է� ����Ű�� �����δ�.
        // z�� �յڹ���(����)���� ������, ���� ����Ű���� 1, ������ -1
        z = Input.GetAxis("Vertical") * 0.1f;
        transform.Translate(x, y, z);

        //���콺�� x������ �巡�� �ϸ� ���� �ٲ�
        r = Input.GetAxis("Mouse X");
        transform.Rotate(0, r, 0);

        //Debug.Log(z); Ȯ���ϰ���� z(����)�� ��
    }
}
