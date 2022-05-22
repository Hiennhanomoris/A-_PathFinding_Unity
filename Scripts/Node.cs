using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Node : MonoBehaviour
{
    public bool walkable;
    public Vector3 woldPosition;
    public Node(bool _walkable, Vector3 _woldPos)
    {
        walkable = _walkable;
        woldPosition = _woldPos;
    }
}
