using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelChangeScript : MonoBehaviour
{

    public int sceneBuildIndex;


    //Switches scene to the selected scenes index number when trigger is entered by the player
    public void ChangeScene()
    {
        SceneManager.LoadScene(sceneBuildIndex, LoadSceneMode.Single);
    }


    //THIS IS FOR WHEN THE PLAYER ENTERS A TRIGGER, JUST FOR FUTURE USE

    //print("Trigger Entered");

        //if (other.tag == "Player")
        //{
            //print("Scene change to " + sceneBuildIndex);
            //SceneManager.LoadScene(sceneBuildIndex, LoadSceneMode.Single);
        //}
}
