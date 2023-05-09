using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{
    public Canvas pauseCanvas;
    public PlayerAutoMove player;

    public void ShowPause()
    {
        player.StopMotion();
        pauseCanvas.gameObject.SetActive(true);
    }

    public void HidePause()
    {
        player.Move();
        player.stopMotion = false;
        pauseCanvas.gameObject.SetActive(false);
    }

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            ShowPause();
        }
    }
}
