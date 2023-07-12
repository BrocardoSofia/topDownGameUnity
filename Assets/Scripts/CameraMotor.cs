using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMotor : MonoBehaviour
{
    public Transform lookAt; //player
    public float boundX = 0.15f, boundY = 0.05f; //the square where the player can move before the camera moves

    private void LateUpdate()
    {
        Vector3 delta = Vector3.zero;

        //check if the player is inside the bounds on the X axis
        float deltaX = lookAt.position.x - transform.position.x; //distance between the player and the center of the camera

        if(deltaX > boundX || deltaX < -boundX)
        {
            if(transform.position.x < lookAt.position.x) 
            {
                delta.x = deltaX - boundX;
            }
            else
            {
                delta.x = deltaX + boundX;
            }
        }

        //check if the player is inside the bounds on the Y axis
        float deltaY = lookAt.position.y - transform.position.y; //distance between the player and the center of the camera

        if (deltaY > boundY || deltaY < -boundY)
        {
            if (transform.position.y < lookAt.position.y)
            {
                delta.y = deltaY - boundY;
            }
            else
            {
                delta.y = deltaY + boundY;
            }
        }

        transform.position += new Vector3(delta.x, delta.y, 0);
    }
}
