using UnityEngine;
using UnityEngine.SceneManagement;

public class AudioPlayerSingleton : MonoBehaviour
{
    public static AudioPlayerSingleton Instance { get; private set; }
    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
            return;
        }
        Destroy(gameObject);
    }
}
