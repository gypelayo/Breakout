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
        for (int line = 0; line< 5; line++)
        {
            for (int column = -7; column < 8; column++)
            {
                GameObject tempObj = Instantiate(brickPrefab, new Vector2(column, line + 3), Quaternion.identity, transform);
                if (line == 0)
                {
                    tempObj.GetComponent<SpriteRenderer>().color = Color.red;
                }
                if (line == 1)
                {
                    tempObj.GetComponent<SpriteRenderer>().color = Color.blue;
                }
                if (line == 2)
                {
                    tempObj.GetComponent<SpriteRenderer>().color = Color.yellow;
                }
                if (line == 3)
                {
                    tempObj.GetComponent<SpriteRenderer>().color = Color.green;
                }
                if (line == 4)
                {
                    tempObj.GetComponent<SpriteRenderer>().color = Color.magenta;
                }
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Cursor.visible = true;
        }
    }
}
