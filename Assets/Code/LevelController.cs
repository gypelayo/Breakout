using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelController : MonoBehaviour
{
    public int numberOfBalls;
    public int lifeCount;
    [SerializeField]
    private Text text;
    [SerializeField]
    private Text numberOfActiveBalls;
    /// <summary>
    /// Start is called on the frame when a script is enabled just before
    /// any of the Update methods is called the first time.
    /// </summary>
    void Start()
    {
        numberOfBalls = 1;
        lifeCount = 5;
        Cursor.visible=false;
    }
    /// <summary>
    /// Update is called every frame, if the MonoBehaviour is enabled.
    /// </summary>
    void Update()
    {
         if (Input.GetKeyDown(KeyCode.Escape))
        {
            Cursor.visible = true;
        }
        text.text = lifeCount.ToString();
        numberOfActiveBalls.text = numberOfBalls.ToString();
        if (lifeCount < 0)
        {
            Application.Quit();
        }
    }
}
