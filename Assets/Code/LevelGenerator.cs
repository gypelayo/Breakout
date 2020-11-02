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
        for (int j = 0; j < 5; j++)
        {
            for (int i = -7; i < 8; i++)
            {
                GameObject tempObj = Instantiate(brickPrefab, new Vector2(i, j + 3), Quaternion.identity, transform);
                if (j == 0)
                {
                    tempObj.GetComponent<SpriteRenderer>().color = Color.red;
                }
                if (j == 1)
                {
                    tempObj.GetComponent<SpriteRenderer>().color = Color.blue;
                }
                if (j == 2)
                {
                    tempObj.GetComponent<SpriteRenderer>().color = Color.yellow;
                }
                if (j == 3)
                {
                    tempObj.GetComponent<SpriteRenderer>().color = Color.green;
                }
                if (j == 4)
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
