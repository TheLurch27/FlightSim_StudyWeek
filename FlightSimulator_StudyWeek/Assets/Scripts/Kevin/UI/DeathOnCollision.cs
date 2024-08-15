using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathOnCollision : MonoBehaviour
{
    public GameObject deathCanvas;

    void Start()
    {
        if (deathCanvas != null)
        {
            deathCanvas.SetActive(false);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Terrain")
        {
            if (deathCanvas != null)
            {
                deathCanvas.SetActive(true);
            }
        }
    }
}