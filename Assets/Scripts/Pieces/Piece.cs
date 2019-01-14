using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public abstract class Piece  {

    protected Vector2Int position;
    public bool MadeFirstMove { get; set; }

    public bool IsWhite { get; set; }
    public PieceType Type { get; }

    public bool IsKing()
    {
        return Type == PieceType.KING;
    }

    public Piece(Vector2Int position, bool isWhite, PieceType type)
    {
        this.position = position;
        this.IsWhite = isWhite;
        this.MadeFirstMove = false;
        this.Type = type;
    }

    public virtual bool IsFieldInWay(Move move)
    {
        return CanMakeMove(move);
    }

    public virtual bool CanMakeCaptureMove(Move move)
    {
        return CanMakeMove(move);
    }

    public abstract bool CanMakeMove(Move move);

    public virtual bool CanPromote()
    {
        return false;
    }

    public void Move(Vector2Int newPosition)
    {
        this.position = newPosition;
    }
}

public enum PieceType
{
    KING = 0,
    QUEEN = 1,
    BISHOP = 2,
    KNIGHT = 3,
    ROOK = 4,
    PAWN = 5
}