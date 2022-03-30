using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    float r;
    // Start is called before the first frame update
    void Start()
    {
        r = 0;
    }

    // Update is called once per frame
    void Update()
    {
        r = Input.GetAxis("Mouse ScrollWheel") * 50;
        transform.Translate(0, r, 0);
    }
}
