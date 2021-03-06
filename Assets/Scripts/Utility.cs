using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Utility
{
    public static Vector2[] directions = new Vector2[]{
        Vector2.up,
        Vector2.right,
        Vector2.down,
        Vector2.left
    };
    public static Vector3 PerpendicularRight(Vector2 v)
    {
        for(int i = 0; i < directions.Length; i++)
        {
            Vector2 dir = directions[i];
            if (dir == v)
            {
                int nextDir = i+1;
                if (nextDir == directions.Length)
                {
                    nextDir = 0;
                }
                return directions[nextDir];
            }
        }
        throw new KeyNotFoundException("Vector " + v + " is not a horizontal or vertical vector.");
    }
    public static Vector3 PerpendicularLeft(Vector2 v)
    {

        for (int i = 0; i < directions.Length; i++)
        {
            Vector2 dir = directions[i];
            if (dir == v)
            {
                int nextDir = i-1;
                if (nextDir < 0)
                {
                    nextDir = directions.Length-1;
                }
                return directions[nextDir];
            }
        }
        throw new KeyNotFoundException("Vector " + v + " is not a horizontal or vertical vector.");
    }
}
