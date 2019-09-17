using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    private void Move()
    {
        //  Have an input from the user
        var deltaX = Input.GetAxis("Horizontal");
        var deltaY = Input.GetAxis("Vertical");

        //  Calculated new position
        var newXPos = transform.position.x + deltaX;
        var newYPos = transform.position.y + deltaY;

        //  Set the current game object to the new position
        transform.position = new Vector2(newXPos, newYPos);

    }
}
