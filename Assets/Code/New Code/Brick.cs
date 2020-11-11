using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brick
{
    private float size;
    private Color color;
    public Brick()
    {
        this.size = 2;
        this.color = Color.grey;
    }
    public Brick(float size)
    {
        this.size = size;
        this.color = Color.grey;
    }
    public Brick(Color color)
    {
        this.size = 2;
        this.color = color;
    }
    public float Size
    {
        get
        {
            return size;
        }
        private set
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
