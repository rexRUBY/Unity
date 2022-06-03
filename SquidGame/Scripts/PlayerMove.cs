using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public GameObject panelW;

    float x, y, z;
    float r;
    void Start()
    {
        x = 0;
        y = 0;
        z = 0;
    }

    void Update()
    {
        z = Input.GetAxis("Vertical") * GameManager.instance.speed * Time.deltaTime;
        transform.Translate(x, y, z);

        x = Input.GetAxis("Horizontal") * GameManager.instance.speed * Time.deltaTime;
        transform.Translate(x, y, z);

        //transform.position 때문에 여기에 위치함.
        if (transform.position.z > 29.33)
        {
            panelW.SetActive(true);
            Time.timeScale = 0;
        }
    }
}