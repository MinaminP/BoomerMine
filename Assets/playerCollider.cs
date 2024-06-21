using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerCollider : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Door"))
        {
            Application.LoadLevel(0);
        }

        if (collision.CompareTag("Explosion"))
        {
            Destroy(this.gameObject);
            Application.LoadLevel(Application.loadedLevel);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Enemy"))
        {
            Destroy(this.gameObject);
            Application.LoadLevel(Application.loadedLevel);
        }
    }
}
