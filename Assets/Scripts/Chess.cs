using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class Chess : MonoBehaviour {

    public Tilemap field;
    public Tilemap hightlighting;
    public Tilemap pieces;

    public Pieces pieceManager;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    #region Events
    public void OnPieceChosen(Vector2Int field, Pieces.Piece piece, bool white)
    {

    }
    #endregion

    private void OnMouseDown()
    {
        Debug.Log("Okay");
        //Die Position des Mausklicks
        Vector2 position = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        //Wenn eine Figur angeklickt wurde
        if (pieces.HasTile(new Vector3Int((int)position.x, (int)position.y, 0)))
        {
            Debug.Log("clicked");
        }
    }
}
