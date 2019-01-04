using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class HighlightingManager : MonoBehaviour {

    public Chess chess;

    //Wird aufgerufen wenn ein Marker angeklickt wurde
    private void OnMouseDown()
    {
        Vector3 positionRaw = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector3Int position = new Vector3Int((int)positionRaw.x, (int)positionRaw.y, 0);

        TileBase tileBase = GetComponent<Tilemap>().GetTile(position);

        chess.OnMarkerChosen(new Vector2Int(position.x, position.y), new Marker(tileBase));
    }
}
