using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //public variable visable in unity inspector
    public float forceStrength;

    //called once per frame by unity
    public void Update()
    {
        //get our rigidbody that we'll need to find the physics information 
        Rigidbody2D ourRigidbody = GetComponent<Rigidbody2D>();

        // find out from the rigidbody what our current horazontal and vertical speeds 
        float currentSpeedH = ourRigidbody.velocity.x;
        float currentSpeedV = ourRigidbody.velocity.y;

        // get the anamator componant that wee will be using for setting our anaimaion 
        Animator ourAnimator = GetComponent<Animator>();

        //Tell our aniamtor what the speeds are 
        ourAnimator.SetFloat("speedH", currentSpeedH);
        ourAnimator.SetFloat("speedV", currentSpeedV);

    }
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
