using UnityEngine;

public class Quit3DButton : MonoBehaviour
{
    private void OnMouseDown()
    {
        Debug.Log("Quit Button Clicked");
        Application.Quit();
    }
}