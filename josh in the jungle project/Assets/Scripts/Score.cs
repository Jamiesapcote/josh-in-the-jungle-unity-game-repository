using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    //public variable 
    public Text scoreDisplay;
    public bool shouldReset = false;

    //private variables 
    private static int scoreValue = 0;

    //called by unity the frame after this object is created 
    void Start()
    {
        //check if we should be reseting the score this scene
        if (shouldReset == true)
        {
            //reset the score value back to 0
            scoreValue = 0;


        }


        //update the display on the core based on the numerical 
        scoreDisplay.text = scoreValue.ToString();
    }



    //function to add the players the score
    //NOT  aoutomatcally called by unity - we need to call it oursleves in our code 
    public void AddScore(int toAdd)
    {
        //update the numerical value of the score (action 1)
        scoreValue = scoreValue + toAdd;

        //update the display on the core based on the numerical 
        scoreDisplay.text = scoreValue.ToString();
    }


}
