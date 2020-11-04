using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGenerator : MonoBehaviour
{
    [SerializeField]
    private GameObject brickPrefab;
    void Start()
    {
        
        Cursor.visible = false;
        InstantiateBricks();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Cursor.visible = true;
        }
    }

    private void InstantiateBricks()
    {
        Debug.Log("Test");
        int bricksVerticalPositionOffset=3;
        /*
            This temporary mechanism instantiates the bricks using its line and column index as position
        */
        for (int line = 0; line< 5; line++)
        {
            for (int column = -7; column < 8; column++)
            {
                GameObject instantiatedBrick = Instantiate(brickPrefab, new Vector2(column, line + bricksVerticalPositionOffset), Quaternion.identity, transform);
                if (line == 0)
                {
                    instantiatedBrick.GetComponent<SpriteRenderer>().color = Color.red;
                }
                if (line == 1)
                {
                    instantiatedBrick.GetComponent<SpriteRenderer>().color = Color.blue;
                }
                if (line == 2)
                {
                    instantiatedBrick.GetComponent<SpriteRenderer>().color = Color.yellow;
                }
                if (line == 3)
                {
                    instantiatedBrick.GetComponent<SpriteRenderer>().color = Color.green;
                }
                if (line == 4)
                {
                    instantiatedBrick.GetComponent<SpriteRenderer>().color = Color.magenta;
                }
            }
        }
    }
}
