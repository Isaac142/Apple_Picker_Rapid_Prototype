using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    //Creating a GameManager to hold all the variabled and functions that are specific to the game.
    public bool isPaused = false;
    public UIManager UI;

    void Start()
    {
        
    }


    //Creating the Pause Screen, if the pause screen is activated, the timer on the game, will freeze, along with all other UI.
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            isPaused = !isPaused;
            UI.Pause(isPaused);
        }
    }
}
