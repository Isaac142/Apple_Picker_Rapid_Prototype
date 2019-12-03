using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{

    public bool isTitleScreen;
    public GameObject pausePanel;
    public GameObject inGamePanel;
    public GameManager GM;

    void Start()
    {
        
    }


    void Update()
    {

    }

    //Loading level, used on the Title screen buttons and the return to title screen button in the game pause menu.
    public void LoadLevel(string levelName)
    {
        SceneManager.LoadScene(levelName);
    }

    //Close the application completely when the Quit button is pressed
    public void QuitGame()
    {
        Application.Quit();
    }

    public void Pause(bool pause)
    {
        
        if(pausePanel != null)
        {
            pausePanel.SetActive(pause);
            inGamePanel.SetActive(!pause);
        }
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
