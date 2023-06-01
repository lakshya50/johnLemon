using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class waypointPatrol : MonoBehaviour
{
    public NavMeshAgent navMeshAgent;
    public Transform[] waypoints;
    int currentWaypoint;
    void Start()
    {
        navMeshAgent.SetDestination(waypoints[0].position);
    }
    void Update()
    {
        if(navMeshAgent.remainingDistance<navMeshAgent.stoppingDistance)
        {
            currentWaypoint=(currentWaypoint+1)%waypoints.Length;
            navMeshAgent.SetDestination(waypoints[currentWaypoint].position);
        }
    }
}
