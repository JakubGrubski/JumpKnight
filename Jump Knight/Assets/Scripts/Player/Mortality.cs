using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mortality : MonoBehaviour
{
    public Canvas gameOverCanvas;
    public GameObject playerPrefab;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy") || collision.gameObject.CompareTag("Obstacle"))
        {
            playerPrefab.SetActive(false);
            gameOverCanvas.gameObject.SetActive(true);
        }
    }
}
