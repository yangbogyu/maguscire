using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mob : MonoBehaviour
{
    Vector3 target = new Vector3(8, 0, 0);
    public Transform goal;

    void Start()
    {
        UnityEngine.AI.NavMeshAgent agent = GetComponent<UnityEngine.AI.NavMeshAgent>();
        agent.destination = goal.position;
    }
    void Update()
    {
        /*
        // Vector3.MoveTowards(현재위치, 목표위치, 속도) 
        // 일정한 속도로 이동
        transform.position = Vector3.MoveTowards(transform.position, target, 0.01f);
        
        // Vector3.SmoothDamp(현제위치, 목표위치, 참조속도, 속도(반비례))
        // 부드러운 이동
        Vector3 velo = Vector3.zero;
        transform.position = Vector3.SmoothDamp(transform.position, target,ref velo, 0.1f);
        

        // Vector3.Lerp
        transform.position = Vector3.Lerp(transform.position, target, 0.01f);
        */
    }
}
