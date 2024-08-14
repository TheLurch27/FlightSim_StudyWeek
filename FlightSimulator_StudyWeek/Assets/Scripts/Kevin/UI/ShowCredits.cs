using UnityEngine;

public class ShowCredits : MonoBehaviour
{
    // Referenz zum Parent GameObject der Polaroids
    public GameObject creditsParent;

    // Diese Methode wird aufgerufen, wenn das GameObject angeklickt wird
    private void OnMouseDown()
    {
        // Parent GameObject aktivieren
        creditsParent.SetActive(true);
    }
}
