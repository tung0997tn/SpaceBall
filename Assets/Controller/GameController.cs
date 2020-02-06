using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    
    public static GameController instant;
    public bool isGameDone = false;
    public bool isPause = false;

    private void Awake()
    {
        if (instant == null)
        {
            instant = this;
        }
    }


    public void GameOver()
    {
        UIController.instant.GameOver();
    }
    public void Winner()
    {
        UIController.instant.Winner();
    }

}
