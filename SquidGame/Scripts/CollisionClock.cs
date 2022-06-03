using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionClock : MonoBehaviour
{
    private void OnCollisionEnter(Collision coll)
    {
        if (coll.gameObject.tag == "Player")
        {
            GameManager.Instance.timeUp();
            Destroy(gameObject);
        }
    }
}