using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MatchingScript : MonoBehaviour
{

    public bool pieceMatching;


    private void OnTriggerEnter2D(Collider2D other)
    {
        print("Pieces Entered");

        if (other.tag == "Player")
        {
            print("Piece Matched");
        }
    }

}
