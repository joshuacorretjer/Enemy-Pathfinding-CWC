using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI; //Add when using NavMesh

public class MoveTo : MonoBehaviour
{

    public Transform goal;
    private NavMeshAgent agent;

    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        agent.destination = goal.position;//it sets the agent's destination to that of the goal
    }
}
