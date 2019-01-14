using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class PieceModelManager : MonoBehaviour {

    public Chess chess;
    public Tilemap tilemap;

    [Header("White")]
    public TileBase kingWhite;
    public TileBase queenWhite;
    public TileBase bishopWhite;
    public TileBase knightWhite;
    public TileBase rookWhite;
    public TileBase pawnWhite;

    [Header("Black")]
    public TileBase kingBlack;
    public TileBase queenBlack;
    public TileBase bishopBlack;
    public TileBase knightBlack;
    public TileBase rookBlack;
    public TileBase pawnBlack;

    private void Start()
    {
        tilemap = GetComponent<Tilemap>();
    }

    //Wird aufgerufen wenn eine Figur angeklickt wurde
    private void OnMouseDown()
    {
        Vector3 positionRaw = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector2Int position = new Vector2Int((int)positionRaw.x, (int)positionRaw.y);

        Field field = chess.GetField(position);
        if (field != null)
        {
            chess.OnPieceChosen(chess.GetField(position));
        }
    }

    public void ShowPieceModel(Field field)
    {
        tilemap.SetTile(tilemap.WorldToCell(field.Get3DPosition()), PieceToTileBase(field.Piece));
    }

    public void ShowNoPieceModel(Field field)
    {
        tilemap.SetTile(tilemap.WorldToCell(field.Get3DPosition()), null);
    }

    public TileBase PieceToTileBase(Piece piece)
    {
        if (piece.IsWhite)
        {
            switch (piece.Type)
            {
                case PieceType.KING:
                    return kingWhite;

                case PieceType.QUEEN:
                    return queenWhite;

                case PieceType.BISHOP:
                    return bishopWhite;

                case PieceType.KNIGHT:
                    return knightWhite;

                case PieceType.ROOK:
                    return rookWhite;

                case PieceType.PAWN:
                    return pawnWhite;
            }
        }

        else
        {
            switch (piece.Type)
            {
                case PieceType.KING:
                    return kingBlack;

                case PieceType.QUEEN:
                    return queenBlack;

                case PieceType.BISHOP:
                    return bishopBlack;

                case PieceType.KNIGHT:
                    return knightBlack;

                case PieceType.ROOK:
                    return rookBlack;

                case PieceType.PAWN:
                    return pawnBlack;
            }
        }

        return null;
    }
}
