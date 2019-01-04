using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class Marker  {

	public enum Color
    {
        NOT_FOUND,
        RED,
        GREEN
    }

    public TileBase tileBase;

    public Marker(TileBase tileBase)
    {
        this.tileBase = tileBase;
    }

    public Color GetColor()
    {
        switch (tileBase.name.Split('_')[0])
        {
            case "red":
                return Color.RED;

            case "green":
                return Color.GREEN;
        }

        return Color.NOT_FOUND;
    }
}
