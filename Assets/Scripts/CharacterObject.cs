using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterObject : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    /*
    private string WhatSideOfTheColliderWasHit(Collider2D collision)
    {
        Vector2 PointOnBoxHit = collision.ClosestPoint(transform.position);
        Vector2 centerOfObject = collision.bounds.center;
        float xMinPoint = Mathf.Abs((collision.bounds.size.x / 2) - centerOfObject.x);
        float xMaxPoint = Mathf.Abs(xMinPoint + collision.bounds.size.x);
        float yMinPoint = Mathf.Abs((collision.bounds.size.y / 2) - centerOfObject.y);
        float yMaxPoint = Mathf.Abs(yMinPoint + collision.bounds.size.y);

        if (PointOnBoxHit.x >= xMinPoint && PointOnBoxHit.x <= xMaxPoint && Approximately(yMaxPoint, PointOnBoxHit.y, .1f))
            return "Bottom";
        else if (PointOnBoxHit.x >= xMinPoint && PointOnBoxHit.x <= xMaxPoint && Approximately(yMinPoint, PointOnBoxHit.y, .1f))
            return "Top";
        else if (PointOnBoxHit.y >= yMinPoint && PointOnBoxHit.y <= yMaxPoint && Approximately(xMaxPoint, PointOnBoxHit.y, .1f))
            return "Right";
        else
            return "Left";
    }
    */
}
