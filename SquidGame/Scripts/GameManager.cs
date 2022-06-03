using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Singleton...
public class GameManager : MonoBehaviour
{
    public static GameManager instance; //Ŭ���� �� ��� ���� �� �Լ� ���
    
    public static GameManager Instance
    {
        get { return instance; }
    }

    //���� ������ �����Ϸ��� �ϴ� �ð�
    public float time=30f;
    //���� ������ �����Ϸ��� �ϴ� �ӵ�
    public float speed = 0.3f;

    private void Awake()  //Awake�� ��ũ��Ʈ���� ���� ���� �����
    {
        if (instance) //instance�� ���� �ƴ϶�� �̹� instance�� �ϳ� �����ϰ� �ִٴ� �ǹ�
        {
            Destroy(gameObject); //�� �̻� �����ϸ� �ȵǴ� ��ü�̴� ��� AWake�� �ڽ��� ����
        }
        else if (!instance) //instance�� �ý��ۻ� �����ϰ� ���� ������
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }

    public void timeUp()
    {
        time += 3f;
        Timer.time += 3;
    }

    public void timeDown()
    {
        time -= 3f;
        Timer.time -= 3;
    }
}