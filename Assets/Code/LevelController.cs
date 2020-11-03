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
    /// <summary>
    /// Start is called on the frame when a script is enabled just before
    /// any of the Update methods is called the first time.
    /// </summary>
    void Start()
    {
        numberOfBalls = 1;
        lifeCount = 5;
    }
    /// <summary>
    /// Update is called every frame, if the MonoBehaviour is enabled.
    /// </summary>
    void Update()
    {
        text.text = lifeCount.ToString();

        if (lifeCount < 0)
        {
            Application.Quit();
        }
    }
}
