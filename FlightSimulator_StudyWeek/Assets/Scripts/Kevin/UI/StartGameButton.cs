using UnityEngine;
using UnityEngine.SceneManagement;  // Für Szenenverwaltung erforderlich

public class StartGameButton : MonoBehaviour
{
    // Name der Szene, die geladen werden soll
    public string sceneName = "FinalGameScene";

    // Diese Methode wird aufgerufen, wenn das Polaroid angeklickt wird
    private void OnMouseDown()
    {
        LoadFinalGameScene();
    }

    // Methode zum Laden der Szene
    public void LoadFinalGameScene()
    {
        // Szene laden
        SceneManager.LoadScene(sceneName);
    }
}