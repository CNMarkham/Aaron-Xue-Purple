using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coin : MonoBehaviour
{
    public GameObject door;

    public ParticleSystem Pickup;

    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {



            Destroy(door);
            Pickup.Play();
            Destroy(gameObject);
        }
       
    }
    void Start()
    {
        Pickup.Stop();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
