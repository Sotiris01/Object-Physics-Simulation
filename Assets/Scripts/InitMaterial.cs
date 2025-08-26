using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitMaterial : MonoBehaviour
{
	// Start is called before the first frame update
	void Start()
	{
		Material mat = GetComponent<Renderer>().material;

		// Random color
		mat.color = new Vector4(Random.Range(0f, 1f),
								Random.Range(0f, 1f),
								Random.Range(0f, 1f), 
								/*Transparency*/ 0.5f);

		foreach (Transform plane in transform)
			plane.GetComponent<Renderer>().material = mat;
	}
}
