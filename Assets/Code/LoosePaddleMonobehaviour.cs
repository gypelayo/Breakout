using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoosePaddleMonobehaviour : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Ball")
        {
            if (GameObject.FindGameObjectsWithTag("Ball").Length == 1)
            {
                DestroyPaddleAndSpawnNew(other);
            }
            else
            {
                Destroy(other.gameObject);
            }
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
            PlayerPrefs.SetInt("Account Balance", gameController.account.Balance);
            SceneManager.LoadScene("HomePage", LoadSceneMode.Single);
        }

    }
}
