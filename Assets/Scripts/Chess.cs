using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class Chess : MonoBehaviour {

    public Tilemap field;
    public Tilemap hightlighting;
    public Tilemap pieces;

    public HighlightingManager highlightingManager;
    public PieceManager pieceManager;

    public static List<Vector2Int> GetFreeFieldPositions()
    {
        List<Vector2Int> allFields = new List<Vector2Int>();

        for (int x = -4; x < 5; x++)
        {
            for (int y = -4; y < 5; y++)
            {
                allFields.Add(new Vector2Int(x, y));
            }
        }

        return allFields;
    }

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    #region Events
    public void OnPieceChosen(Vector2Int field, Piece piece)
    {
        
    }

    public void OnMarkerChosen(Vector2Int field, Marker marker)
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
            Debug.Log(position);
        }
    }
}
