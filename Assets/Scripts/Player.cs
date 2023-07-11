using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private BoxCollider2D boxCollider;

    private Vector3 moveDelta;

    private void Start()
    {
        boxCollider = GetComponent<BoxCollider2D>();
    }

    private void FixedUpdate()
    {
        float x = Input.GetAxisRaw("Horizontal");//1(d), 0(no keys) or -1(a) depending on the keys
        float y = Input.GetAxisRaw("Vertical");//1(w), 0(no keys) or -1(s) depending on the keys

        //Reset moveDelta
        moveDelta = new Vector3(x,y,0);

        //Swipe Sprite direction (right or left)
        if (moveDelta.x > 0)
            transform.localScale = Vector3.one;
        else if (moveDelta.x < 0)
            transform.localScale = new Vector3(-1, 1, 1);

        //make the player move
        transform.Translate(moveDelta * Time.deltaTime);
    }

    
}
