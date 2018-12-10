using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class Pieces : MonoBehaviour {

    public Chess chess;

    public enum Piece
    {
        KING,
        ROOK,
        BISHOP,
        QUEEN,
        KNIGHT,
        PAWN
    }

    public void Start()
    {
        //Generieren der Spielfiguren

    }

    //Wird aufgerufen wenn eine Figur angeklickt wurde
    private void OnMouseDown()
    {
        Vector3 position = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        TileBase tileBase = GetComponent<Tilemap>().GetTile(new Vector3Int((int)position.x, (int)position.y, (int)position.z));
        string tileName = tileBase.name;
        string typeString = tileName.Split('_')[0];
        string colorString = tileName.Split('_')[1];

        Piece type;
        bool color;
    }
}
