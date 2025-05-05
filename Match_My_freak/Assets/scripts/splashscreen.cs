using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class splashscreen : MonoBehaviour
{
    public void PlayButton()
    {
        SceneManager.LoadScene("level_one");
    }
}
