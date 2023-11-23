using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float xForce;
    public float yForce;
    public float xDirection;
    private Rigidbody2D enemyRigidBody;

    // Start is called before the first frame update
    // 
    
    private void Start()
    {
        enemyRigidBody = GetComponent<Rigidbody2D>();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            Vector2 jumpForce = new Vector2(xForce * xDirection, yForce);
            enemyRigidBody.AddForce(jumpForce);         

        }
        if (collision.gameObject.tag == "Player")
        {
            collision.gameObject.GetComponent<Rigidbody2D>().AddForce(Vector2.right * 3000);
            
        }

    }
    private void FixedUpdate()
    {

        if (transform.position.y >= 4)
        {
            enemyRigidBody.AddForce(Vector2.down * yForce);

        }
        if (transform.position.x <= -7)
        {
            xForce = 1;
            enemyRigidBody.AddForce(Vector2.right * xForce);
        }
        if (transform.position.x >= 7)
        {
            xForce = -1;
            enemyRigidBody.AddForce(Vector2.left * xForce);
        }
    }



}
    

 

