using UnityEngine;
using UnityEngine.SceneManagement;

public class SlideshowManager : MonoBehaviour
{
    public float slideDuration = 55f;  // 4 Bilder x 10 Sekunden
    public string nextSceneName = "FinalGameScene";  // Name der nächsten Szene

    private void Start()
    {
        // Lade die nächste Szene nach Ablauf der Diashow
        Invoke("LoadNextScene", slideDuration);
    }

    private void LoadNextScene()
    {
        SceneManager.LoadScene(nextSceneName);
    }
}
