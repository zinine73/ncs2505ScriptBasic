using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;
public class EnumScript : MonoBehaviour
{
    enum Direction { North, East, South, West };

    void Start()
    {
        Direction myDirection = Direction.North;
        
        int dir = (int)myDirection;
        int len = System.Enum.GetValues(typeof(Direction)).Length;
        // System에 있는 Random 이용
        var rand1 = new System.Random();
        //myDirection = (Direction)(rand1.Next() % len);

        // UnityEngine에 있는 Random 이용
        var rand2 = Random.Range(0, len - 1);
        myDirection = (Direction)rand2;
        Debug.Log(myDirection);

        var returnDirection = ReverseDirection(myDirection);
        Debug.Log(returnDirection);
    }

    int ReDirection(int dir)
    {
        switch ((Direction)dir)
        {
            case Direction.North:
                dir = (int)Direction.South;
                break;
            case Direction.South:
                dir = (int)Direction.North;
                break;
            case Direction.East:
                dir = (int)Direction.West;
                break;
            case Direction.West:
                dir = (int)Direction.East;
                break;
            default:
                break;
        }
        return dir;
    }

    Direction ReverseDirection(Direction dir)
    {
        /*
        if (dir == Direction.North)
            dir = Direction.South;
        else if (dir == Direction.South)
            dir = Direction.North;
        else if (dir == Direction.East)
            dir = Direction.West;
        else if (dir == Direction.West)
            dir = Direction.East;
        */
        switch (dir)
        {
            case Direction.North:
                dir = Direction.South;
                break;
            case Direction.South:
                dir = Direction.North;
                break;
            case Direction.East:
                dir = Direction.West;
                break;
            case Direction.West:
                dir = Direction.East;
                break;
            default:
                Debug.Log("잘못된 값입니다.");
                break;
        }
        return dir;
    }
}
