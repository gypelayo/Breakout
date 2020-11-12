using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle
{
    private float horizontalSize;
    private float verticalSize;
    private Color color;
    private Vector2 position;
    public Paddle()
    {
        horizontalSize = 2;
        verticalSize = 0.5f;
        position = new Vector2(0,-8.75f);
        color = Color.grey;
    }
    public Paddle(float horizontalSize)
    {
        this.horizontalSize = horizontalSize;
        verticalSize = 0.5f;
        position = new Vector2(0,-8.75f);
        color = Color.grey;
    }
    public float HorizontalSize
    {
        get
        {
            return horizontalSize;
        }
    }
    public Vector2 Position
    {
        get
        {
            return position;
        }
        set
        {

            position = value;
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
    public void SetColor(Color color)
    {
        this.color = color;
    }
}
