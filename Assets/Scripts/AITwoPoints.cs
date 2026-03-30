using UnityEngine;
using UnityEngine.AI;
// I got this code from Unity Documentation.
// https://docs.unity3d.com/Packages/com.unity.ai.navigation@1.1/manual/NavAgentPatrol.html

public class AITwoPoints : MonoBehaviour
{
  public Transform[] points;
  private int destPoint = 0;
  private NavMeshAgent agent;

  void Start()
  {
    agent = GetComponent<NavMeshAgent>();
    agent.autoBraking = false;
    GotoNextPoint();
  }

  void GotoNextPoint()
  {
    if (points.Length == 0)
      return;
    agent.destination = points[destPoint].position;
    destPoint = (destPoint + 1) % points.Length;
  }

  void Update()
  {
    if (!agent.pathPending && agent.remainingDistance < 0.5f)
      GotoNextPoint();
  }
}
