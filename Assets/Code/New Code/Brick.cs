using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brick
{
    private float size;
    public Brick()
    {
        this.size = 2;
    }
    public Brick(float size)
    {
        this.size = size;
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
}
