using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRotate : MonoBehaviour
{
    float r;
    float rotateSpeed = 80;
    // Start is called before the first frame update
    void Start()
    {
        r = 0;
    }

    // Update is called once per frame
    void Update()
    {
        r = Input.GetAxis("Mouse X") * Time.deltaTime * rotateSpeed;
        transform.Rotate(0, r, 0);
    }
}
