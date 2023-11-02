using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    public bool canJump;
    Rigidbody rigidbody;

    float jumpForce = 5.7f;
    public bool isGrounded;
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    void Update()
    {
        isGrounded = Physics.Raycast(transform.position, Vector3.down, .15f);
        Debug.DrawRay(transform.position, Vector3.down * .15f, Color.red);
        if (rigidbody.velocity.y > -.01 && rigidbody.velocity.y < .01)
        {
            canJump = true;
        }
        else
        {
            canJump = false;
        }

        if (Input.GetButtonDown("Jump"))
        {
            
            rigidbody.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            
        }


    }
}
    

