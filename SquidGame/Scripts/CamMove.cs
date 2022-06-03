using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamMove : MonoBehaviour
{
	public Transform target;
	float dist = 4.5f;
	float height = 3.0f;
	float dampRotate = 0.5f;
	Transform tr;

	void Start()
	{
		tr = GetComponent<Transform>();
	}

	void LateUpdate()
	{
		float currYAngle = Mathf.LerpAngle(tr.eulerAngles.y, target.eulerAngles.y, dampRotate * Time.deltaTime);
		Quaternion rot = Quaternion.Euler(0, currYAngle, 0);

		tr.position = target.position - (rot * Vector3.forward * dist) + (Vector3.up * height);
		tr.LookAt(target);
	}
}
