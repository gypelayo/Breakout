using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle
{
    private float horizontalSize;
    private float verticalSize;
    private Color color;
    public Paddle()
    {
        horizontalSize = 2;
        verticalSize = 0.5f;
    }
    public Paddle(float horizontalSize)
    {
        this.horizontalSize = horizontalSize;
    }
    public float HorizontalSize
    {
        get
        {
            return horizontalSize;
        }
        set
        {

        }
    }
    public Color Color
    {
        get
        {
            return color;
        }
        set
        {

        }
    }
}
