using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brick
{
    private float size;
    private Color color;
    private Vector2 position;
    private GameObject brickGameObject;
    private SpriteRenderer spriteRenderer;
    public Brick()
    {
        this.size = 2;
        this.color = Color.grey;
    }
    public Brick(float size)
    {
        this.size = size;
        this.color = Color.grey;
        this.position = new Vector2(0, 0);
    }
    public Brick(Color color)
    {
        this.size = 2;
        this.color = color;
    }
    public Brick(float size, Color color)
    {
        this.size = size;
        this.color = color;
    }
    public float Size
    {
        get
        {
            return size;
        }
        set
        {

            size = value;
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

            color = value;
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
    public GameObject BrickGameObject
    {
        get
        {
            return brickGameObject;
        }
        set
        {
            brickGameObject = value;
            //Set spriteRenderer
            spriteRenderer = brickGameObject.AddComponent<SpriteRenderer>();
            //Set Color
            spriteRenderer.color = color;
            //SetSize
            brickGameObject.transform.localScale = new Vector3(size,1,1);
        }
    }
    public SpriteRenderer GetSpriteRenderer()
    {
        return spriteRenderer;
    }
    public void SetColor(Color color)
    {
        this.color=color;
        spriteRenderer.color = color;
    }
}
