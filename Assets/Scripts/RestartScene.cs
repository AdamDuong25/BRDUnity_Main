using UnityEngine;
using UnityEngine.SceneManagement;
// This code was acquired using Bing's AI (top search results).

public class RestartScene : MonoBehaviour
{
  public void RestartCurrentScene()
  {
    SceneManager.LoadScene(SceneManager.GetActiveScene().name);
  }
}
