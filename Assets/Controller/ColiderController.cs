using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColiderController : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(GameController.instant.isGameDone == false && other.tag == "Wall")
        {
            GameController.instant.isGameDone = true;
            GameController.instant.GameOver();
        }
        if(GameController.instant.isGameDone==false && other.tag == "Win")
        {
            GameController.instant.isGameDone = true;
            GameController.instant.Winner();
        }
    }
}
