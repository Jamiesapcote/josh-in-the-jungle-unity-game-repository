using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnimePatrol : MonoBehaviour
{
    //public varables 
    public float fourceStrength;//how fast to move 
    public Vector2[] patrolPoints; //patrol points we will move to
    public float stopDistance; //how close we get before moving to next patrol
    
    //private varabables 
    private Rigidbody2D ourRigidbody; // the rigidbody on this object used to move 
    private int currentPoint = 0; // index of the current point were moving towards 




    //awake is called when the script is loaded 
    void Awake()
    {
        //get the rigidbodty attached to the object for movment 
        ourRigidbody = GetComponent<Rigidbody2D>();
    }


    // Update is called once per frame
    void Update()
    {
        //how far are we from our target?
        float distance = (patrolPoints[currentPoint] - (Vector2)transform.position).magnitude;

        //if we are closer to our target then our minimum distance...
        if (distance <=stopDistance)
        {
            //... then update to the next target #
            currentPoint = currentPoint + 1;

            // if we've gone past the end of our list...
            //(if our current point index is equal or bigger than 
            //the length of our list 
            if (currentPoint >= patrolPoints.Length)
            {
                //.... then, loop back to the start 
                //by setting current idex to 0
                currentPoint = 0;


            }

        }

        //move in the derection of our taget

        //get the direction wee should move in 
        // subrtacting the current position from the target position
        Vector2 direction = (patrolPoints[currentPoint] - (Vector2)transform.position).normalized;

        //move in the correct direction with the set fouce strength
        ourRigidbody.AddForce(direction * fourceStrength);

    }
}
