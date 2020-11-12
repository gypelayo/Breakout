using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineController : MonoBehaviour
{
    [SerializeField]
    private Color lineColor;

    void Start()
    {
        for (int childIndex = 0; childIndex < transform.childCount; childIndex++)
        {
            if (!transform.GetChild(childIndex).GetComponent<BrickScript>().isExplosive)
            {
                transform.GetChild(childIndex).GetComponent<SpriteRenderer>().color = lineColor;
            }

        }
    }
}
