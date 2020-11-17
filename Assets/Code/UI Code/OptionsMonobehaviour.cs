using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.Events;
﻿using UnityEngine;
using UnityEngine.SceneManagement;

public class OptionsMonobehaviour : MonoBehaviour
{
    [SerializeField]
    private GameObject mainMenu;
    [SerializeField]
    private GameObject optionsMenu;
    [SerializeField]
    private GameObject storeMenu;

    public void StartGame()
    {

        SceneManager.LoadScene("Breakout", LoadSceneMode.Single);
    }
    public void ExitGame()
    {

        UnityEditor.EditorApplication.isPlaying = false;
        Application.Quit();
    }
    public void GoToOptions()
    {

        Debug.Log("Not implemented");
    }
    public void GoToScore()
    {

        mainMenu.SetActive(false);
        storeMenu.SetActive(true);
    }
    public void ReturnToMainMenu()
    {
        storeMenu.SetActive(false);
        mainMenu.SetActive(true);
    }
}
