using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    NavMeshAgent2D agent; //NavMeshAgent2D
    [SerializeField] Transform target; //추적 타겟

    void Start()
    {
        agent = GetComponent<NavMeshAgent2D>(); //agent NavMeshAgent2D
    }

    void Update()
    {
        agent.destination = target.position; //agent 목적지 좌표
        //agent.SetDestination(target.position); //이 문법도 가능
    }
}
