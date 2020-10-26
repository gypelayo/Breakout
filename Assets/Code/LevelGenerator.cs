using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGenerator : MonoBehaviour
{
    [SerializeField]
    private GameObject brickPrefab;
    void Start()
    {
        for(int i = -7; i < 8; i++)
        {
            GameObject tempObj = Instantiate(brickPrefab, new Vector2(i, 6), Quaternion.identity, transform);

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
