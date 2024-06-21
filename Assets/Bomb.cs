﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb : MonoBehaviour
{
    public float countdown = 2f;
    // Update is called once per frame
    void Update()
    {
        countdown -= Time.deltaTime;

        if(countdown <= 0)
        {
            FindObjectOfType<BrickDestroy>().Explosion(transform.position);
            Destroy(gameObject);
        }
    }
}
