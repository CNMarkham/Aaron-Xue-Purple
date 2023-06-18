using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenWrap : MonoBehaviour
{
    private Vector2 screenMin;
    private Vector2 screenMax;


    // Start is called before the first frame update
    void Start()
    {
        screenMin = Camera.main.ScreenToWorldPoint(new Vector2(0, 0));
        screenMin = Camera.main.ScreenToWorldPoint(new Vector2(Screen.width, Screen.height));
    }

    // Update is called once per frame
    void Update()
    {
        float x = transform.position.x;
        float y = transform.position.y;

        if (x > screenMax.x)
        {

        }
        if (x > screenMax.x)
        {

        }
        if (x > screenMax.y)
        {

        }
        if (x > screenMax.y)
        {

        }
    }
}
