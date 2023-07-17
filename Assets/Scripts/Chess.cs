using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chess : Collectable
{
    public Sprite emptyChess;
    public int pesosAmount = 5; 

    protected override void OnCollect()
    {
        if(!collected)
        {
            base.OnCollect();
            Debug.Log("Grant " + pesosAmount + " Pesos");
            GetComponent<SpriteRenderer>().sprite = emptyChess;
        }
    }
}
