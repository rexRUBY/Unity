using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionBom : MonoBehaviour
{
    private void OnCollisionEnter(Collision coll)
    {
        if (coll.gameObject.tag == "Player")
        {
            GameManager.Instance.timeDown();
            Destroy(gameObject);
        }
    }
}
