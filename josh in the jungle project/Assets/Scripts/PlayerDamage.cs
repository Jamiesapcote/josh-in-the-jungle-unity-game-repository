using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDamage : MonoBehaviour
{

    // CONDITON when the projectile hits a certain object type... (enemy)
    void OnTriggerEnter2D(Collider2D otherCollider)
    {
        //check if the object we collided with has the tag we are looking for (enemy)
        if (otherCollider.CompareTag("enemy ") == true)
        {
            //perfrom our action 
            killEnemy(otherCollider.gameObject);
        }


    }


    //ACTION : Kill the enemy using dedtroy 
    public void killEnemy(GameObject enemy)
    {

        //chech if the enemy has the "scoreKill" component
        ScoreKill scoreKillScript = enemy.GetComponent<ScoreKill>();
        if (scoreKillScript != null)
        { 
            //this means our enemy has a score value 
            Score playerScore = FindObjectOfType<Score>();

            //add the value from scorekillscript
            playerScore.AddScore(scoreKillScript.KillValue);
        }


        //destroy the enemy
        Destroy(enemy);


    }

}
