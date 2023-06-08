using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public float speed;

    // Update is called once per frames
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(Vector2.right * Time.deltaTime * speed);

        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(Vector2.left * Time.deltaTime * speed);


        }
    }
}
