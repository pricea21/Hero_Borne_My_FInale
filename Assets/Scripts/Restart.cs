using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{
    public void restartGame()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1.0f;
    }
}
