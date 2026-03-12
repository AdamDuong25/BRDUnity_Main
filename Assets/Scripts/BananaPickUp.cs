using UnityEngine;
using TMPro;

public class BananaPickUp : MonoBehaviour
{
  [SerializeField] GameObject ButtonMenu;
  TextMeshProUGUI winText;

  private void Start()
  {
    winText = GameObject.Find("Win").GetComponent<TextMeshProUGUI>();
    winText.text = "";
    ButtonMenu.SetActive(false);
  }

  private void OnTriggerEnter(Collider other)
  {
    gameObject.SetActive(false);
    AudioManager.instance.PlaySound("PointGrab");

    winText.text = "NICE!";
    ButtonMenu.SetActive(true);
    AudioManager.instance.PlaySound("TreasureGet");
  }
}
