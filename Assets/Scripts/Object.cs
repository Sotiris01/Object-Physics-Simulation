using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Object : MonoBehaviour
{
	private Rigidbody rigidbody;

	private GameObject SC;

	int size;

	// Start is called before the first frame update
	void Start()
	{
		// Random Color
		GetComponent<Renderer>().material.color = new Vector4(	Random.Range(0f, 1f),
																Random.Range(0f, 1f),
																Random.Range(0f, 1f));

		// Random Size
		size = Random.Range(1, 11);
		transform.localScale *= size;

		// Random direction
		var direction = new Vector3(Random.Range(0.1f, 0.9f), 
									Random.Range(0.1f, 0.9f), 
									Random.Range(0.1f, 0.9f));

		rigidbody = GetComponent<Rigidbody>();

		SC = GameObject.FindGameObjectWithTag("SC");

		var speed = SC.GetComponent<ObjectsSpeed>().speed;

		rigidbody.velocity = direction * speed;

	}

	// Update is called once per frame
	void Update()
	{
	 	var speed = SC.GetComponent<ObjectsSpeed>().speed;

		rigidbody.velocity = speed * (rigidbody.velocity.normalized);

		var position = transform.position;

		position.x = Mathf.Clamp(position.x, size/2, 100 - size/2);
		position.y = Mathf.Clamp(position.y, size/2, 100 - size/2);
		position.z = Mathf.Clamp(position.z, size/2, 100 - size/2);

		transform.position = position;
	}
}
