using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrickScript : MonoBehaviour
{
    [SerializeField]
    private GameObject xplosionPrefab;
    [SerializeField]
    public bool isExplosive;

    /// <summary>
    /// Start is called on the frame when a script is enabled just before
    /// any of the Update methods is called the first time.
    /// </summary>
    void Start()
    {
        if (isExplosive)
        {
            GetComponent<SpriteRenderer>().color = Color.grey;
        }
    }

    [System.Obsolete]
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Ball")
        {
            Destroy(gameObject);
            
            if (!isExplosive)
            {
                GameObject instantiatedXplosion = Instantiate(xplosionPrefab, transform.position, Quaternion.identity, null);
                instantiatedXplosion.GetComponent<CircleCollider2D>().enabled = false;
                instantiatedXplosion.GetComponent<ParticleSystem>().startColor = GetComponent<SpriteRenderer>().color;

                Destroy(instantiatedXplosion, 3);
            }
            else
            {
                GameObject instantiatedXplosion = Instantiate(xplosionPrefab, transform.position, Quaternion.identity, null);
                instantiatedXplosion.transform.localScale = new Vector3(1, 1, 1);
                instantiatedXplosion.GetComponent<ParticleSystem>().startSize = 3;
                instantiatedXplosion.GetComponent<ParticleSystem>().startColor = Color.red;

                Destroy(instantiatedXplosion, 3);
            }
        }

    }
}
