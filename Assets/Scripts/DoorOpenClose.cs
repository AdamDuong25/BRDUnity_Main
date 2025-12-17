using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class DoorOpenClose : MonoBehaviour
{
  private Animator DoorAnim;

  void Start()
  {
    DoorAnim = GetComponent<Animator>();
  }

  void Update()
  {
    if (DoorAnim != null)
    {
      if (Input.GetKeyDown(KeyCode.O))
      {
        DoorAnim.SetTrigger("TrOpen");
      }
      if (Input.GetKeyDown(KeyCode.C))
      {
        DoorAnim.SetTrigger("TrClose");
      }
    }
  }
}
