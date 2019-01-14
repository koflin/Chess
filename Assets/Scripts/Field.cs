﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Field {

    public Vector2Int Position { get; }
    public Piece Piece { get; set; }
    public Marker Marker { get; set; }

    public bool edited = false;

    public Field(int x, int y)
    {
        this.Position = new Vector2Int(x, y);
        this.Piece = null;
    }

    public bool IsOccupied()
    {
        return Piece != null;
    }

    public Move GetMoveTo(Field field)
    {
        return new Move(field.Position - this.Position);
    }

    public string GetFieldName()
    {
        List<string> xName = new List<string>() { "a", "b", "c", "d", "e", "f", "g", "h" };
        List<string> yName = new List<string>() { "1", "2", "3", "4", "5", "6", "7", "8" };
        return xName[Position.x] + yName[Position.y];
    }

    public Vector3Int Get3DPosition()
    {
        return new Vector3Int(Position.x, Position.y, 0);
    }
}
