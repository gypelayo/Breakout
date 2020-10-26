using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Death : MonoBehaviour
{
    [SerializeField]
    private GameObject playerPrefab;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Ball")
        {
            Destroy(collision.collider.gameObject);
            Destroy(transform.parent.GetChild(0).gameObject);
            GameObject temp = Instantiate(playerPrefab, transform.parent.position, Quaternion.identity, transform.parent);
            temp.transform.SetAsFirstSibling();
        }
    }
}
