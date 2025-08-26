using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeTexture : MonoBehaviour
{

	public Material SimplMat;

	Material TextMat;

	bool textON = false;

    void Start()
    {
		TextMat = new Material(Shader.Find("Standard"));
		TextMat.mainTexture = Resources.Load("texture-sphere") as Texture2D;
    }

    // Update is called once per frame
    void Update()
	{
		if (Input.GetKeyDown(KeyCode.T))
		{
			textON = !textON;
			GetComponent<Renderer>().material = textON ? TextMat : SimplMat;
		}
	}
}
