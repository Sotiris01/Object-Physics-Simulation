using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateSmallObjects : MonoBehaviour
{
	public GameObject cube;
	public GameObject sphere;
	public GameObject cylinder;

	private float time = 0.0f;


	// Update is called once per frame
	void Update()
	{
		if (Input.GetKeyDown(KeyCode.Space))
			makeObject();

		if (Input.GetKey(KeyCode.Space))
		{
			time += Time.fixedDeltaTime;
			if (time > 0.5f)
				makeObject();
		}
		if (Input.GetKeyUp(KeyCode.Space))
			time = 0.0f;
	}

	private void makeObject()
	{
		switch (Random.Range(0, 3))
		{
			case 0:
				Instantiate(cube, new Vector3(0, 0, 0), Quaternion.identity);
				break;
			case 1:
				Instantiate(sphere, new Vector3(0, 0, 0), Quaternion.identity);
				break;
			case 2:
				Instantiate(cylinder, new Vector3(0, 0, 0), Quaternion.identity);
				break;
			default:
				break;
		}
	}
}
