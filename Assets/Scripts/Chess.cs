using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chess : Collidable
{
    protected override void OnCollide(Collider2D coll)
    {
        Debug.Log("Grant pesos");
    }
}
