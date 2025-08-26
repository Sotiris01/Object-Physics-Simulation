using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CapsuleMovement : MonoBehaviour
{

	public float speed = 50f;

	// Update is called once per frame
	void Update()
	{
		if (Input.GetKey(KeyCode.W))
			transform.position += transform.forward * Time.deltaTime * speed;
		if (Input.GetKey(KeyCode.S))
			transform.position -= transform.forward * Time.deltaTime * speed;


		if (Input.GetKey(KeyCode.D))
			transform.position += transform.right * Time.deltaTime * speed;
		if (Input.GetKey(KeyCode.A))
			transform.position -= transform.right * Time.deltaTime * speed;


		if (Input.GetKey(KeyCode.E))
			transform.position += transform.up * Time.deltaTime * speed;
		if (Input.GetKey(KeyCode.X))
			transform.position -= transform.up * Time.deltaTime * speed;
	}
}
