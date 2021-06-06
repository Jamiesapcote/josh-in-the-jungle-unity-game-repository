using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScorePickup : MonoBehaviour
{
    //public variables 
    //editable in unity 
    //usable in other scripts 
    public int pickupValue = 1;

    //called by unity when this object overlaps anohter object marked as trigger
    void OnTriggerEnter2D(Collider2D other)
    {
        //check if the score script is attached to thee thing we haved bumped into
        Score scoreScript = other.GetComponent<Score>();

        if (scoreScript != null)
        {
            //we have a score script, so the thing we bumped into is the player 
            //add  our pick up value to the player's current score (actions)

            scoreScript.AddScore(pickupValue);
            //we should then deleate this object  so we dont infinitly add score 
            Destroy(gameObject);
        }
    }

}
