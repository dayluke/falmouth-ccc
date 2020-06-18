﻿using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenuHandler : MonoBehaviour
{
    public Object mainMenuScene;
    public InputHandler inputHandler;
    public GameObject pauseMenu;
    public GameObject optionsMenu;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)) OnPauseClick();
    }
    
    #region settings-buttons

    public void OnPauseClick()
    {
        if (optionsMenu.activeInHierarchy)
        {
            optionsMenu.SetActive(!optionsMenu.activeInHierarchy);
            return;
        }
        
        bool openPauseMenu = !pauseMenu.activeInHierarchy;
        inputHandler.inputEnabled = !openPauseMenu;
        pauseMenu.SetActive(openPauseMenu);
    }

    public void OnOptionsClick()
    {
        bool openOptionsMenu = pauseMenu.activeInHierarchy;
        optionsMenu.SetActive(openOptionsMenu);
        pauseMenu.SetActive(!openOptionsMenu);
    }

    public void OnExitClick()
    {
        SceneManager.LoadScene(mainMenuScene.name);
    }

    #endregion

    #region options-buttons

    public void OnAudioClick()
    {

    }

    #endregion
}