using UnityEngine;
using UnityEngine.SceneManagement;

public class MysteryCapsule : MonoBehaviour
{
  private void OnTriggerEnter(Collider other)
  {
    AudioManager.instance.PauseMusic();
    SceneManager.LoadScene("Level - Temple");
  }
}
