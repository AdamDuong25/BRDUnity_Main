using UnityEngine;
using TMPro;

public class BananaPickUp : MonoBehaviour
{
  [SerializeField] GameObject ButtonNextLevel;
  [SerializeField] GameObject ButtonMenu;
  TextMeshProUGUI winText;

  private void Start()
  {
    winText = GameObject.Find("Win").GetComponent<TextMeshProUGUI>();
    winText.text = "";
    ButtonNextLevel.SetActive(false);
    ButtonMenu.SetActive(false);
  }

  private void OnTriggerEnter(Collider other)
  {
    gameObject.SetActive(false);
    AudioManager.instance.PlaySound("PointGrab");
    winText.text = "NICE!";
    ButtonNextLevel.SetActive(true);
    ButtonMenu.SetActive(true);
    AudioManager.instance.PlaySound("TreasureGet");
    Cursor.lockState = CursorLockMode.None;
  }
}
