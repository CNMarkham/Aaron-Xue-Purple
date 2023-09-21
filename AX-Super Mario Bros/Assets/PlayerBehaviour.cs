using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehaviour : MonoBehaviour
{
    public bool big;
    public SpriteRenderer smallRenderer;
    private Animator smallAnimator;
    public SpriteRenderer bigRenderer;
    
    // Start is called before the first frame update
    private void Start()
    {
        smallAnimator = smallRenderer.gameObject.GetComponent<Animator>();
        big = false;
    }

    public void Hit()
    {
        if (big)
        {
            Shrink();
        }
        else
        {
            Death();
        }
    }
    /// <summary>
    /// Shrinking Mario
    /// </summary>
    private void Shrink()
    {
        // stop drawing big mario and draw small mario
        smallRenderer.enabled = true;
        bigRenderer.enabled = false;

        // gets the collider component, and set its size to 1 because mario has shrinked
        GetComponent<CapsuleCollider2D>().size = Vector2.one;
        // it changes the offset to 0 because so the small mario can touch the floor
        GetComponent<CapsuleCollider2D>().offset = Vector2.zero;

        // it turns false because the big mario turned small
        big = false;
        //call the changesize coroutine
        StartCoroutine("ChangeSize");
    }

    /// <summary>
    /// growing mario
    /// </summary>
    public void Grow()
    {
        // it tells big mario to spawn
        if (big)
        {
            return;
        }
        //when the small mario hited a mushroom it will turn him off and turn on big mario
        smallRenderer.enabled = false;
        bigRenderer.enabled = true;

        //it changes the collider size bigger because the small collider is too small for big mario
        GetComponent<CapsuleCollider2D>().size = new Vector2(1f, 2f);
        // it changes the offset because big mario will be in the ground
        GetComponent<CapsuleCollider2D>().offset = new Vector2(0, 0.036282f);

        //it turned on big mario because the small mario touched a mushroom
        big = true;
        //it called the changedsize coroutine
        StartCoroutine("ChangeSize");
    }
     // it makes the mario die
    private void Death()
    {
        //it turns on the death parameter when the mario touchs the goomba or koopa
        smallAnimator.SetTrigger("death");
       // it turns off the capsule collider
        GetComponent<CapsuleCollider2D>().enabled = false;
        //it lets things stay up or else everything will fall
        GetComponent<Rigidbody2D>().velocity = Vector2.up * 10;
        //it makes the player stop moving
        GetComponent<PlayerMovement>().enabled = false;
        //it destroys the object
        Destroy(gameObject, 0.5f);

    }

    /// <summary>
    /// Coroutine Method
    /// Change size
    /// </summary>
    /// <returns></returns>
    private IEnumerator ChangeSize()
    {
        // make a rigidbody2d variable rb to hold the rigidbody2d component of this object
        Rigidbody2D rb = GetComponent<Rigidbody2D>();
        // get the velocity of this rigidbody and store it in a vector 3 variable named velocity
        Vector3 velocity = rb.velocity;
        // it makes the player stop moving
        GetComponent<PlayerMovement>().enabled = false;
        // it turned off the capsule collider
        GetComponent<CapsuleCollider2D>().enabled = false;
        rb.isKinematic = true;
        rb.velocity = Vector3.zero;
        

        for (int i = 0; i < 8; i++)
        {
            bigRenderer.enabled ^= true;
            smallRenderer.enabled ^= true;
            yield return new WaitForSeconds(0.25f);
        }

        rb.isKinematic = false;
        rb.velocity = velocity;
        GetComponent<PlayerMovement>().enabled = true;
        GetComponent<CapsuleCollider2D>().enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
