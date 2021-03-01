using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //public variable visable in unity inspector
    public float forceStrength;
    //these will be called by each button for movment 
    public void MoveLeft()
    {
        // get the rigidbody tjat we'll be using for movment 
        Rigidbody2D OurRidgidbody = GetComponent<Rigidbody2D>();

        //move in the correct direction with the set force strength 
        OurRidgidbody.AddForce(Vector2.left * forceStrength);

    }
    public void MoveRight()
    {
        // get the rigidbody tjat we'll be using for movment 
        Rigidbody2D OurRidgidbody = GetComponent<Rigidbody2D>();

        //move in the correct direction with the set force strength 
        OurRidgidbody.AddForce(Vector2.right * forceStrength);
    }

}
