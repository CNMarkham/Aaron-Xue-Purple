using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class WalkingSphere : MonoBehaviour
{
    private NavMeshAgent agent;
    public Transform goal;
    
    // Start is called befoqre the first frame update
    private void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        agent.destination = goal.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
