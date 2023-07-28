using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Fighter
{
    private BoxCollider2D boxCollider;
    private Vector3 moveDelta;
    private RaycastHit2D hit;

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


        //Make sure we can move in this direction()y, by casting a box there first
        hit = Physics2D.BoxCast(transform.position, boxCollider.size, 0, new Vector2(0, moveDelta.y),
                                Mathf.Abs(moveDelta.y * Time.deltaTime), LayerMask.GetMask("Actor", "Blocking"));

        if(hit.collider == null)
        {
            //the box return null, so player can move

            //make the player move in the axes y
            transform.Translate(0,moveDelta.y * Time.deltaTime,0);
        }

        //Make sure we can move in this direction(x), by casting a box there first
        hit = Physics2D.BoxCast(transform.position, boxCollider.size, 0, new Vector2(moveDelta.x, 0),
                                Mathf.Abs(moveDelta.x * Time.deltaTime), LayerMask.GetMask("Actor", "Blocking"));

        if (hit.collider == null)
        {
            //the box return null, so player can move

            //make the player move in the axes y
            transform.Translate(moveDelta.x * Time.deltaTime, 0, 0);
        }

    }

    
}
