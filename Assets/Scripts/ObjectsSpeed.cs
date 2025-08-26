using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectsSpeed : MonoBehaviour
{
    public float speed = 30;

    private float speedUp = 1;
    private float minSpeed = 1;
    private float maxSpeed = 150;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Period))   // Press ">" -> speed up
            speed += speedUp;
        if (Input.GetKey(KeyCode.Comma))    // Press "<" -> speed down
            speed -= speedUp;
        speed = Mathf.Clamp(speed, minSpeed, maxSpeed);
    }
}
