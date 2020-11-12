using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public List<Brick> bricks;
    public int numberOfBricks=0;
    private void Awake()
    {
        bricks = new List<Brick>();
    }
}
