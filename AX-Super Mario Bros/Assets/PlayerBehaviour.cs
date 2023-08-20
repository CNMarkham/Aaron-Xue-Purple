using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehaviour : MonoBehaviour
{
    public bool big;
    public SpriteRenderer smallRenderer;
    public Animator smallAnimator;
    public SpriteRenderer bigRenderer;
    // Start is called before the first frame update
  public void Start()
    {
        smallAnimator = smallRenderer.gameObject.GetComponent<Animator>();
        big = false;
    }


   public void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
