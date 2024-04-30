using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemigo : MonoBehaviour
{
    // Start is called before the first frame update
    UnityEngine.AI.NavMeshAgent myNavMeshAgent;
    public GameObject jugador;
    void Start()
    {
        myNavMeshAgent = GetComponent<UnityEngine.AI.NavMeshAgent>();

    }

    // Update is called once per frame
void FixedUpdate()
{
    if(myNavMeshAgent.enabled){
        myNavMeshAgent.SetDestination(jugador.transform.position);
    }
}
void OntriggerEnter(Collider c){
    if(c.gameObject.tag == "Player")
    {
        myNavMeshAgent.enabled=true;
    }
}
}
