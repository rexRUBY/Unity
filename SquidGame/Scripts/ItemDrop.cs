using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDrop : MonoBehaviour
{
    public GameObject Item;
    void Start()
    {
        InvokeRepeating("Spawnitem", 0, 5);
    }

    void Spawnitem()
    {
        float random1 = Random.Range(-10f, 10f);
        float random2 = Random.Range(-19f, 35f);

        if (true)
        {
            GameObject item = (GameObject)Instantiate(Item, new Vector3(random1, 1f, random2), Quaternion.identity);
        }
    }
}