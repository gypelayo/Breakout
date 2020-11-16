using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Powerup
{
    private int id;
    public Powerup()
    {
        id = 0;
    }
    public int Id
    {
        get
        {
            return id;
        }
        set
        {
            id = value;
        }
    }
}
