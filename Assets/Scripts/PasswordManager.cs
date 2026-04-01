using UnityEngine;
using TMPro;

public class PasswordManager : MonoBehaviour
{
  [Header("Door Animation")]
  public Animator DoorAnimL;
  public Animator DoorAnimR;
  private string correctPassword = "VUOKSI25";
  public string currentPassword = ""; // Remains "public" for playtesting purposes.

  [Header("Game Over UI")]
  [SerializeField] GameObject ButtonRetry;
  [SerializeField] GameObject ButtonNextLevel;
  [SerializeField] GameObject ButtonMenu;
  TextMeshProUGUI loseText;

  void Start()
  {
    loseText = GameObject.Find("Lose").GetComponent<TextMeshProUGUI>();
    loseText.text = "";
    ButtonRetry.SetActive(false);
    ButtonNextLevel.SetActive(false);
    ButtonMenu.SetActive(false);
  }
  
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
      else
      {
        loseText.text = "Wrong password!";
        ButtonRetry.SetActive(true);
        ButtonNextLevel.SetActive(true);
        ButtonMenu.SetActive(true);
      }
    }
  }
}
