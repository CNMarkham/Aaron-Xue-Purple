using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpScript : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody2D rigidbody;
    public float jumpForce = 10;
    public bool canJump;
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();


    }

    // Update is called once per frame
    void Update()
    {
        if (rigidbody.velocity.y > -.01 && rigidbody.velocity.y < .01)
        {
            canJump = true;
        }
        else
        {
            canJump = false;
        }
         
        if (canJump && Input.GetButtonDown("Jump"))
        {
            rigidbody.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
        }

    }
}
