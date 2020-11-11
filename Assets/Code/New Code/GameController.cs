using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{

    public List<GameObject> gameObjects;
    private List<Brick> bricks;
    private Brick brick1;
    [SerializeField]
    private GameObject brickDefault;
    private void Start()
    {
        brick1 = new Brick();
        bricks.Add(brick1);
       /* foreach (Brick brick in bricks)
        {
            GameObject brickGameObject = Instantiate(brickDefault, transform.position, Quaternion.identity, null);
            gameObjects.Add(brickGameObject);
        }*/
    }
}
