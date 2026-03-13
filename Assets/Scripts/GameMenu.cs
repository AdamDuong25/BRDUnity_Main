using UnityEngine;
using UnityEngine.SceneManagement;

public class GameMenu : MonoBehaviour
{
  public void PlayGame()
  {
    SceneManager.LoadScene("Level - 1");
  }

  public void QuitGame()
  {
    Debug.Log("You quit the game.");
    Application.Quit();
  }
}
