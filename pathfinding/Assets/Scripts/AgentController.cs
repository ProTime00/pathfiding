using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AgentController : MonoBehaviour
{
    public Transform agentDest;
    // Update is called once per frame
    void Update()
    {
        var agent = GetComponent<NavMeshAgent>();
        agent.destination = agentDest.position;
    }
}
