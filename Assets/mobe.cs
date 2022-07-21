using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class mobe : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField] Transform target;
    NavMeshAgent agent;
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        agent.updateRotation = false;
        agent.updateUpAxis = false;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(target.position);
        agent.SetDestination(target.position);
    }
}
