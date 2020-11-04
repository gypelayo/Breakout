using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosionsController : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Brick")
        {
            Destroy(other.gameObject);
        }
    }


}
