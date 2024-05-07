using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemigo : MonoBehaviour
{
    UnityEngine.AI.NavMeshAgent myNavMeshAgent;
    public GameObject jugador;
    private Animator animator;
    void Start()
    {
        myNavMeshAgent = GetComponent<UnityEngine.AI.NavMeshAgent>();
        animator = GetComponent<Animator>();
    }

void FixedUpdate()
{
    if(myNavMeshAgent.enabled){
        myNavMeshAgent.SetDestination(jugador.transform.position);
        //animator.SetBool("walking", walking);
    }
}
void OntriggerEnter(Collider c){
    if(c.gameObject.tag == "Player")
    {
        myNavMeshAgent.enabled=true;
        //animator.SetBool("attacking", attack);
    }
}
}
