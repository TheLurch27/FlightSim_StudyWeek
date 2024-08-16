using UnityEngine;

public class QuitButton : MonoBehaviour
{
    public void QuitGame()
    {
        // Diese Zeile funktioniert nur in einer gebuildeten Anwendung, nicht im Unity Editor
        Application.Quit();

        // Optional: Um im Editor zu testen, füge diese Zeile hinzu
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#endif
    }
}