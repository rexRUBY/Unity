using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EnemyAnim : MonoBehaviour
{
    Animator anim;
    public Transform player;
    NavMeshAgent nvAgent;
    public Image hpBar;
    public Text txt;
    int score = 0;

    void Start()
    {
        anim = GetComponent<Animator>();
        nvAgent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        float dist = Vector3.Distance(player.position, transform.position); //tramsfprm.position 나의 위치
        nvAgent.destination = player.position;
        if (dist > 3 )
        {
            anim.SetBool("IsRun", true);
        }
        else
        {
            anim.SetBool("IsRun", false);
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Bullet")
        {
            hpBar.fillAmount -= 0.25f;
            txt.text = "Score : " + ++score;

            if(score==4) //즉, 클리어 하면 scene을 이동한다. 왜냐? 4번 맞으면 죽으니까~~
            {
                SceneManager.LoadScene("SecondScene");
            }
        }
    }
}
