using UnityEngine;
using UnityEngine.AI;

public class AIFollow : MonoBehaviour
{
  public Transform target;  // For example the player or other objects.
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
