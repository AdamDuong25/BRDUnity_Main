using UnityEngine;

public class ButtonDownUp : MonoBehaviour
{
  bool isPressed;
  PasswordManager manager;
  public Animator ButtonAnim;
  public string symbol;

  void Start()
  {
    ButtonAnim = GetComponent<Animator>();
    manager = FindAnyObjectByType<PasswordManager>();
    isPressed = false;
  }

  private void OnTriggerEnter(Collider player)
  {
    if (ButtonAnim != null && !isPressed && player.tag == "Player")
    {
      ButtonAnim.SetTrigger("TrDown");
      manager.updatePassword(symbol);
      isPressed = true;
    }
  }
}
