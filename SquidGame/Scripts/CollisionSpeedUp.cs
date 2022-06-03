using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionSpeedUp : MonoBehaviour
{
    public void OnCollisionEnter(Collision coll)
    {
        if (coll.gameObject.tag == "Player")
        {
            Destroy(gameObject);
            GameManager.instance.speed=1.5f;
            StartCoroutine(speedUp());
            GameManager.instance.speed = 0.3f;
        }
    }

    IEnumerator speedUp()
    {
        yield return new WaitForSeconds(3f);  //2초 뒤 다시 제어권을 넘김.
    }
}
