using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class Piece  {

    public enum Category
    {
        NOT_FOUND,
        KING,
        ROOK,
        BISHOP,
        QUEEN,
        KNIGHT,
        PAWN
    }

    public enum Color
    {
        NOT_FOUND,
        WHITE,
        BLACK
    }

    public TileBase tileBase;
    public Vector2Int position;

    public Piece(TileBase tileBase, Vector2Int position)
    {
        this.tileBase = tileBase;
        this.position = position;
    }

    public Category GetCategory()
    {
        switch (tileBase.name.Split('_')[0])
        {
            case "king":
                return Category.KING;

            case "rook":
                return Category.ROOK;

            case "bishop":
                return Category.BISHOP;

            case "queen":
                return Category.QUEEN;

            case "knight":
                return Category.KNIGHT;

            case "pawn":
                return Category.PAWN;
        }

        return Category.NOT_FOUND;
    }

    public Color GetColor()
    {
        switch (tileBase.name.Split('_')[1])
        {
            case "white":
                return Color.WHITE;

            case "black":
                return Color.BLACK;
        }

        return Color.NOT_FOUND;
    }

    public bool IsMoveAllowed(Vector2Int movedPosition)
    {
        Vector2Int move = movedPosition - position;
        switch (GetCategory())
        {
            case Category.KING:
                if (IsMoveLegthOne(move))
                {
                    return true;
                }
                return false;

            case Category.ROOK:
                if (IsMoveHorizontal(move) || IsMoveVertical(move))
                {
                    return true;
                }
                return false;

            case Category.BISHOP:
                if (IsMoveSideWays(move))
                {
                    return true;
                }
                return false;

            case Category.QUEEN:
                if (IsMoveSideWays(move) || IsMoveHorizontal(move) || IsMoveVertical(move))
                {
                    return true;
                }
                return false;

            case Category.KNIGHT:
                if (IsMoveLShaped(move))
                {
                    return true;
                }
                return false;
        }
    }

    public bool IsPieceInWay(Piece piece)
    {
        IsMoveAllowed(piece.position - position);
    }

    private bool IsMoveSideWays(Vector2Int move)
    {
        //Seitliche Bewegung
        if (Mathf.Abs(move.x) == Mathf.Abs(move.y))
        {
            return true;
        }

        return false;
    }

    private bool IsMoveHorizontal(Vector2Int move)
    {
        //Horizontale Bewegung
        if (move.y == 0)
        {
            return true;
        }

        return false;
    }

    private bool IsMoveVertical(Vector2Int move)
    {
        //Vertikale Bewegung
        if (move.x == 0)
        {
            return true;
        }

        return false;
    }

    private bool IsMoveLegthOne(Vector2Int move)
    {
        //Eine Bewegung um ein Feld
        if (Mathf.Abs(move.x) <= 1 && Mathf.Abs(move.y) <= 1)
        {
            return true;
        }

        return false;
    }

    private bool IsMoveForward(Vector2Int move)
    {
        if (GetColor() == Color.WHITE)
        {
            if (move.y > 0)
            {
                return true;
            }
        }

        else if (GetColor() == Color.BLACK)
        {
            if (move.y < 0)
            {
                return true;
            }
        }

        return false;
    }

    private bool IsMoveLShaped(Vector2Int move)
    {
        if ()
    }
}
