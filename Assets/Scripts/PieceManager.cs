using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class PieceManager : MonoBehaviour {

    public Chess chess;

    //Wird aufgerufen wenn eine Figur angeklickt wurde
    private void OnMouseDown()
    {
        Vector3 positionRaw = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector3Int position = new Vector3Int((int)positionRaw.x, (int)positionRaw.y, 0);

        TileBase tileBase = GetComponent<Tilemap>().GetTile(position);

        chess.OnPieceChosen(new Vector2Int(position.x, position.y), new Piece(tileBase));
    }
}
