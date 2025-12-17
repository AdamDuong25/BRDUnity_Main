using UnityEngine;

public class PasswordManager : MonoBehaviour
{
  public Animator DoorAnimL;
  public Animator DoorAnimR;
  [SerializeField] string correctPassword;
  public string currentPassword = "";
  
  public void updatePassword(string A)
  {
    currentPassword += A;
    if (currentPassword == correctPassword && DoorAnimL != null && DoorAnimR != null)
    {
      DoorAnimL.SetTrigger("TrOpen");
      DoorAnimR.SetTrigger("TrOpen");
    }
  }
}
