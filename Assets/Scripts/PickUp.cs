using UnityEngine;
using TMPro;

public class PickUp : MonoBehaviour
{
  [SerializeField] static int score = 0;
  [SerializeField] static int winScore = 5;
  [SerializeField] GameObject ButtonNextLevel;
  [SerializeField] GameObject ButtonMenu;
  TextMeshProUGUI scoreText;
  TextMeshProUGUI winText;

  private void Start()
  {
    scoreText = GameObject.Find("Score").GetComponent<TextMeshProUGUI>();
    scoreText.text = "Score: 0";
    score = 0;
    winText = GameObject.Find("Win").GetComponent<TextMeshProUGUI>();
    winText.text = "";
    ButtonNextLevel.SetActive(false);
    ButtonMenu.SetActive(false);
    AudioManager.instance.PlayMusic("MiamiBassline");
  }

  private void OnTriggerEnter(Collider other)
  {
    score++;
    scoreText.text = "Score: " + score;
    gameObject.SetActive(false);
    AudioManager.instance.PlaySound("PointGrab");
    if (score == winScore)
    {
      winText.text = "YOU WIN!";
      ButtonNextLevel.SetActive(true);
      ButtonMenu.SetActive(true);
      AudioManager.instance.PauseMusic();
      AudioManager.instance.PlaySound("CheesyIntro");
    }
  }
}
