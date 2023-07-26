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
            GetComponent<SpriteRenderer>().sprite = emptyChess;

            // +5 pesos
            GameManager.instance.ShowText("+" + pesosAmount + " pesos!", 14, Color.yellow, transform.position,
                                           Vector3.up * 50, 1.0f);
        }
    }
}
