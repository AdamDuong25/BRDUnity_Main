using UnityEngine;

public class PasswordManager : MonoBehaviour
{
  public Animator DoorAnimL;
  public Animator DoorAnimR;
  private string correctPassword = "VUOKSI25";
  public string currentPassword = ""; // For playtesting purposes.
  
  public void updatePassword(string A)
  {
    currentPassword += A;
    if (currentPassword.Length == 8 && DoorAnimL != null && DoorAnimR != null)
    {
      if (currentPassword == correctPassword)
      {
        DoorAnimL.SetTrigger("TrOpen");
        DoorAnimR.SetTrigger("TrOpen");
      }
      else Debug.Log("Wrong password, fool!");
    }
  }
}
