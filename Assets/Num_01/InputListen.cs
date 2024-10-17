using UnityEngine;
using UnityEngine.SceneManagement;

public class InputListen : MonoBehaviour
{
    void Update()
    {
        RestartScene();
    }

    static void RestartScene()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
