using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Mover
{
    private void FixedUpdate()
    {
        float x = Input.GetAxisRaw("Horizontal");//1(d), 0(no keys) or -1(a) depending on the keys
        float y = Input.GetAxisRaw("Vertical");//1(w), 0(no keys) or -1(s) depending on the keys

        UpdateMotor(new Vector3 (x, y, 0));
    }

}
