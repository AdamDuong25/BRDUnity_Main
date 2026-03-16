using UnityEngine;
using UnityEngine.AI;

public class ObjectClickMove : MonoBehaviour
{
  private NavMeshAgent agent;

  void Start()
  {
    agent = GetComponent<NavMeshAgent>();
  }

  void Update()
  {
    if (Input.GetMouseButtonDown(0)) // vasen hiiren klikkaus
    {
      Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
      RaycastHit hit;

      if (Physics.Raycast(ray, out hit))
      {
        // Tarkista osuiko navmesh-alueeseen
        agent.SetDestination(hit.point);
      }
    }
  }
}
