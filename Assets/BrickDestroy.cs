using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class BrickDestroy : MonoBehaviour
{
    public Tilemap tilemap;

    public Tile wallTile;
    public Tile brickTile;
    public GameObject explosionPrefab;

    public void Explosion(Vector2 worldPos)
    {
        Vector3Int originCell = tilemap.WorldToCell(worldPos);

        ExplodeCell(originCell);
        ExplodeCell(originCell + new Vector3Int(1, 0, 0));
        ExplodeCell(originCell + new Vector3Int(0, 1, 0));
        ExplodeCell(originCell + new Vector3Int(-1, 0, 0));
        ExplodeCell(originCell + new Vector3Int(0, -1, 0));
    }

    bool ExplodeCell (Vector3Int cell)
    {
        Tile tile = tilemap.GetTile<Tile>(cell);

        if (tile == wallTile)
        {
            return false;
        }
        
        if (tile == brickTile)
        {
            tilemap.SetTile(cell, null);
        }

        Vector3 pos = tilemap.GetCellCenterWorld(cell);
        Instantiate(explosionPrefab, pos, Quaternion.identity);
        return true;
    }
}
