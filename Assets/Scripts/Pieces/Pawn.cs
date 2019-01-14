using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pawn : Piece
{
    public Pawn(Vector2Int position, bool isWhite) : base(position, isWhite, PieceType.PAWN)
    {
    }

    public override bool CanMakeMove(Move move)
    {
        if (move.IsMoveForward(IsWhite) && move.IsMoveVertical())
        {
            if (MadeFirstMove)
            {
                return move.IsMoveLegthOne();
            }

            return move.IsMoveLegthOne() || move.IsMoveLengthTwo();
        }

        return false;
    }

    public override bool CanMakeCaptureMove(Move move)
    {
        return move.IsMoveForward(IsWhite) && move.IsMoveLegthOne() && move.IsMoveSideWays();
    }

    public override bool CanPromote()
    {
        if (IsWhite)
        {
            if (position.y == 7)
            {
                return true;
            }
        }

        else
        {
            if (position.y == 0)
            {
                return true;
            }
        }

        return false;
    }
}
