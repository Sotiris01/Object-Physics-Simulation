using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SPHMovement : MonoBehaviour
{
	public float speed = 100;

	float min;
	float max;
	float radius = 15;
	

	// Start is called before the first frame update
	void Start()
	{
		min = 0 + radius;
		max = 100 - radius;
	}

	// Update is called once per frame
	void Update()
	{
		var position = transform.position;

		if (Input.GetKey(KeyCode.RightArrow))                                 // X
			position += transform.right * Time.deltaTime * speed;
		if (Input.GetKey(KeyCode.LeftArrow))
			position -= transform.right * Time.deltaTime * speed;


		if (Input.GetKey(KeyCode.UpArrow))                                     // Y
			position += transform.up * Time.deltaTime * speed;
		if (Input.GetKey(KeyCode.DownArrow))
			position -= transform.up * Time.deltaTime * speed;



		if (Input.GetKey(KeyCode.KeypadPlus) || Input.GetKey(KeyCode.Equals))   // Z
			position += transform.forward * Time.deltaTime * speed;
		if (Input.GetKey(KeyCode.KeypadMinus) || Input.GetKey(KeyCode.Minus))
			position -= transform.forward * Time.deltaTime * speed;


		position.x = Mathf.Clamp(position.x, min, max);
		position.y = Mathf.Clamp(position.y, min, max);
		position.z = Mathf.Clamp(position.z, min, max);

		transform.position = position;
	}
}
