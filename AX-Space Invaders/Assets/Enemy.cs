using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    // Start is called before the first frame update
    public float speed;
    private Animator animator;
    static private Vector2 direction;
    void Start()
    {
        animator = GetComponent<Animator>();
        direction = Vector2.right;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        animator.SetTrigger("death");
        Destroy(gameObject, 1f);
        Destroy(collision.gameObject);
    }
    // Update is called once per frame
    void Update()
    {
        transform.Translate(direction * Time.deltaTime * speed);

        if (transform.position.x > 12f)
        {
            direction = Vector2.left;
            MoveDown();
        }


        if (transform.position.x < -12f)
        {
            direction = Vector2.right;
            MoveDown();
        }
    
    
    }
    private void MoveDown()
    {
        foreach (Enemy enemy in FindObjectsOfType(typeof(Enemy)))
        {
            enemy.transform.Translate(Vector2.down);
        }
    } 
}
