using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrickScript : MonoBehaviour
{
    [SerializeField]
    private GameObject xplosionPrefab;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Ball")
        {
            GameObject instantiatedXplosion = Instantiate(xplosionPrefab, transform.position, Quaternion.identity, null);
            instantiatedXplosion.GetComponent<ParticleSystem>().startColor = GetComponent<SpriteRenderer>().color;
            Destroy(instantiatedXplosion, 3);
            Destroy(gameObject);
        }
    }
}
