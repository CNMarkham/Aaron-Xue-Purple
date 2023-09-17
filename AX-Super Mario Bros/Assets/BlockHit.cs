using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockHit : MonoBehaviour
{
    public GameObject item;
    public int maxHits = -1;
    public Sprite emptyBlock;
    private Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponentInChildren<Animator>();
    }
    public void Hit()
    { 
        if (maxHits <= 0)
        {
            return;
        }
        if (item != null)
        {
            Debug.Log(transform);
            Instantiate(item, transform);
            Debug.Log("anim " + animator);
            animator.SetTrigger("hit");
            maxHits--;
        }
        if (maxHits == 0)
        {
            SpriteRenderer spriteRenderer = GetComponentInChildren<SpriteRenderer>();
            spriteRenderer.sprite = emptyBlock;
        }
        
    }
    
}
