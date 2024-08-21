using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class LevelManager : MonoBehaviour
{
   
    public void LoadLevel(string name){
        //Debug.Log("req : " + name);
        //Application.LoadLevel(name);
        SceneManager.LoadScene(name);
    }

    public void QuitReq(){
       // Debug.Log("req for quit");
       Application.Quit();
    }

    public void LoadNextLevel(){
        SceneManager.LoadScene(SceneManager.sceneCount + 1);
    }

}
