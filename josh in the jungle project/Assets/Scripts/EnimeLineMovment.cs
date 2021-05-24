using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnimeLineMovment : MonoBehaviour
{
    //public varables 
    //exposed for editting in the unity eeditor 
    public float forcestrenghth; //how hard the script pushes the 
                                 //enemy aka how fast the enemy moves 
    public Vector2 direction; //what direction the enemy should move in 

    //privet varables 
    //not visable 
    //used for tracking data while thye game is running 
    private Rigidbody2D ourRigidbody; //the container for the rigidbody 
                                      // attached to this object
    

        //awake is calleed when the script is first loaded 
    void Awake ()
    {
        //geet and store the rigidbody we'll be using for movment 
        ourRigidbody = GetComponent<Rigidbody2D>();

        // normanlise our direction
        // normalise changes it to be length 1, so we can multiply 
        //it by our speed / fouce later
        direction = direction.normalized;

    }

    // Update is called once per frame
    void Update()
    {
        //move in the correct direction with the set fouce strength
        ourRigidbody.AddForce(direction * forcestrenghth);
        
    }
}
