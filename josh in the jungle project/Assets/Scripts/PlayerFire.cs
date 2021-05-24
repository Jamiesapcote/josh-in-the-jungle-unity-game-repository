using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFire : MonoBehaviour
{
    //unity editor variable
    public GameObject projectilleprefab;
    public Vector2 projectillevelocity;
    //action fire a projectile 
    public void Fireprojectille()
    {
        //clone the projectille 
        //declare a variable to hold the clone object 
        GameObject cloneprojectille;
        //use instatuate to clone the projectille and keep the result in our varible 
        cloneprojectille = Instantiate(projectilleprefab);

        //position the projectile on the player 
        cloneprojectille.transform.position = transform.position; //OPTIONAL : Add an offset (use a public varable) 

        //fire it in a direction
        // declare a variable to hold the cloned objects rigedbody 
        Rigidbody2D projectillerigidbody;
        //get the rigedbody from our cloned projectille and store it 
        projectillerigidbody = cloneprojectille.GetComponent<Rigidbody2D>();
        //set the velocity on the rigeedbody to the editor setting 
        projectillerigidbody.velocity = projectillevelocity;
    }

}
