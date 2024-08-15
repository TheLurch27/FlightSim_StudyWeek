using UnityEngine;
using UnityEngine.SceneManagement;

public class SlideshowManager : MonoBehaviour
{
    public float slideDuration = 55f;  // 4 Bilder x 10 Sekunden
    public string nextSceneName = "FinalGameScene";  // Name der n�chsten Szene

    private void Start()
    {
        // Lade die n�chste Szene nach Ablauf der Diashow
        Invoke("LoadNextScene", slideDuration);
    }

    private void LoadNextScene()
    {
        SceneManager.LoadScene(nextSceneName);
    }
}
