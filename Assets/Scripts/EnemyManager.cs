// Partially inspired by Copilot.
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyManager : MonoBehaviour
{
  void Update()
  {
    GameObject[] enemies = GameObject.FindGameObjectsWithTag("Enemy");
    if (enemies.Length == 0)
    {
      WinCondition();
    }
  }

  void WinCondition()
  {
    Cursor.lockState = CursorLockMode.None;
    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
  }
}
