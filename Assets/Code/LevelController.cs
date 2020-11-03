using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelController : MonoBehaviour
{
    public int numberOfBalls;
    public int lifeCount;

    /// <summary>
    /// Start is called on the frame when a script is enabled just before
    /// any of the Update methods is called the first time.
    /// </summary>
    void Start()
    {
        numberOfBalls=1;
        lifeCount=5;
    }
    /// <summary>
    /// Update is called every frame, if the MonoBehaviour is enabled.
    /// </summary>
    void Update()
    {
        if (numberOfBalls<=0){
            lifeCount--;
        }
        if(lifeCount<0){
            Application.Quit();
        }
    }
}
