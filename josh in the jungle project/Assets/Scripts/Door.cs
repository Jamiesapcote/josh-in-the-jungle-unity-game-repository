using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Door : MonoBehaviour
{

    public string levelToLoad;


    private void OnTriggerEnter2D(Collider2D otherCollider)
    {
        // Debug.Log("object hit the door");

        if(otherCollider.tag == "Player")
        {
            SceneManager.LoadScene(levelToLoad);
        }

    }


}
