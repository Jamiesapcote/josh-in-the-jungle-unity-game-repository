using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
    //function must be called by us , not automatically by unity 
    public void LoadTargetScene(string sceneToLoad)
    {
        SceneManager.LoadScene(sceneToLoad);
    }


}
