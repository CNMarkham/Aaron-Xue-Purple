using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goomba : MonoBehaviour
{

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            GetComponent<Animator>().SetTrigger("death");
            GetComponent<CircleCollider2D>().enabled = false;
            GetComponent<EnemyMovement>().enabled = false;
        }
        else
        {

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
