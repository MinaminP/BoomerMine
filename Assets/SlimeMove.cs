using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlimeMove : MonoBehaviour
{

    public float accelerationTime = 0.5f;
    public float maxSpeed = 5f;
    private Vector2 movement;
    private float timeLeft;
    public Rigidbody2D rb;

    void Update()
    {
        timeLeft -= Time.deltaTime;
        if (timeLeft <= 0)
        {
            movement = new Vector2(Random.Range(-5f, 5f), Random.Range(-5f, 5f));
            timeLeft += accelerationTime;
        }
    }

    void FixedUpdate()
    {
        rb.AddForce(movement * maxSpeed);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.CompareTag("Explosion"))
        {
            Destroy(this.gameObject);
        }
    }
    }
