using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoosePaddleMonobehaviour : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Ball")
        {
            DestroyPaddleAndSpawnNew(other);
        }
    }

    private void DestroyPaddleAndSpawnNew(Collider2D other)
    {

        GameController gameController = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameController>();

        if (gameController.paddles.Count > 1)
        {
            gameController.LoosePaddle();
            Destroy(other.gameObject);
            Destroy(GameObject.FindGameObjectWithTag("Player"));
            gameController.SpawnNewPaddle();
        }
        else
        {
            UnityEditor.EditorApplication.isPlaying = false;
            Application.Quit();
        }

    }
}
