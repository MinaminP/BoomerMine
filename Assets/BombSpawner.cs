using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;
using UnityStandardAssets.CrossPlatformInput;

public class BombSpawner : MonoBehaviour
{
    public GameObject bombPrefab;
    public void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            DropBomb ();
        }
    }

    void DropBomb()
    {
        Instantiate(bombPrefab, this.gameObject.transform.position, Quaternion.identity);
    }
}
