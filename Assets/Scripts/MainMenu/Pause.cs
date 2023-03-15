using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour
{
    public static bool GameIsPaused = false;
    public GameObject pausedMenuUI;
    public GameObject settingsUI;

    private void Start()
    {
        pausedMenuUI.SetActive(false);
        settingsUI.SetActive(false);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPaused)
            {
                Resume();
                Cursor.lockState = CursorLockMode.Locked;
            }
            else
            {
                PauseGame();
                Cursor.lockState = CursorLockMode.None;
            }
        }
    }
    void Resume()
    {
        pausedMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }
    void PauseGame()
    {
        pausedMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }

    public void Quit()
    {
        Application.Quit();
    }

    public void ResumeButton()
    {
        Resume();
        Cursor.lockState = CursorLockMode.Locked;
    }
    public void ToMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void PauseMenu()
    {
        settingsUI.SetActive(true);
        pausedMenuUI.SetActive(false);
    }

    public void UnPause()
    {
        settingsUI.SetActive(false);
        pausedMenuUI.SetActive(true);
    }
}
