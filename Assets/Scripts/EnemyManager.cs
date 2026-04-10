// Partially inspired by Copilot.
using System.Collections;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyManager : MonoBehaviour
{
  [SerializeField] GameObject instructions;

  void Update()
  {
    GameObject[] enemies = GameObject.FindGameObjectsWithTag("Enemy");
    if (enemies.Length == 0)
    {
      StartCoroutine(WinCondition());
    }
  }

  IEnumerator WinCondition()
  {
    instructions.SetActive(false);
    Cursor.lockState = CursorLockMode.None;
    yield return new WaitForSeconds(1);
    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
  }
}
