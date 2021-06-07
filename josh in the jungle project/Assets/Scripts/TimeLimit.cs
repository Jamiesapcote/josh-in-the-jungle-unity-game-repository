using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TimeLimit : MonoBehaviour
{

    //public varables 
    //edittable in unity by other scripts 
    public float timelimit; //number of seconds the game lasts
    public string gameOverScene; //scene to be loaded when time runs out

    private float startTime;
    private Text timerDisplay; //the display for our timer
    // Start is called before the first frame update
    void Start()
    {
        //getting our text component so we can edit the text each created 
        timerDisplay = GetComponent<Text>();
        //set the start for when this object was created 
        startTime = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        //calculate how much time has passed 
        float timePassed = Time.time - startTime;

        //display time since start
        timerDisplay.text = ((int)(timelimit - timePassed)).ToString();

        //check if the time limit has been reached 
        if (timePassed >= timelimit)
        {
            //we are out of time load game over scene
            SceneManager.LoadScene(gameOverScene);
        }
    }
}
