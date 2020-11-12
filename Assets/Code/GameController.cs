using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{

    public List<GameObject> realBricks;
    private List<Brick> bricks;
    [SerializeField]
    private GameObject brickDefault;
    private void Start()
    {
        bricks = new List<Brick>();
        foreach (GameObject realBrick in realBricks)
        {
            Brick newBrick = new Brick();
            newBrick.BrickGameObject = realBrick;
            bricks.Add(newBrick);
        }
    }
}
