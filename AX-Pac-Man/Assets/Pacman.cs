using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pacman : Movement
{
    protected override void ChildUpdate()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");
        if (horizontal != 0 || vertical != 0)
        {
            SetDirection(new Vector2(horizontal, vertical));
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
