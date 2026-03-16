using UnityEngine;
using UnityEngine.AI;

public class AIFollow : MonoBehaviour
{
  public Transform target;  // esim. pelaaja tai muu kohde mihin NPC liikkuu
  private NavMeshAgent agent;

  void Start()
  {
    agent = GetComponent<NavMeshAgent>();
  }

  void Update()
  {
    if (target != null)
    {
      agent.SetDestination(target.position);
    }
  }
}
