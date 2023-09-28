using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tetromino : MonoBehaviour
{

    public float fallTime = 0.8f;
    private float previousTime;
    public float speed;
    public static float width = 10;
    public static float height = 20;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            transform.Translate(Vector2.right);

        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            transform.Translate(Vector2.left);


        }
        float tempTime = fallTime;

        if (Input.GetKey(KeyCode.DownArrow))
        {
            tempTime = tempTime / 10;


        }


        if (Time.time - previousTime > tempTime)
        {

        }



    }

    public bool ValidMove()
    {
        foreach (Transform child in transform)
        {
            int x = Mathf.RoundToInt(child.transform.position.x);
            int y = Mathf.RoundToInt(child.transform.position.y);

            //if (x < 0 || y < 0  || ) ;
        }
    }
}