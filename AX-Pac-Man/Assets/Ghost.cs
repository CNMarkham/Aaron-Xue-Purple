using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ghost : Movement
{
    protected override void ChildUpdate()
    {

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Node node = collision.GetComponent<Node>();

        if (node != null)
        {
            int index = Random.Range(0, node.availableDirections.Count);



            SetDirection(node.availableDirections[index]);
        }
    }
    // Start is called before the first frame update
    void Start()
    {

        rb = GetComponent<Rigidbody2D>();

    }

 
}
