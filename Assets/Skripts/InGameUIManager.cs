using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InGameUIManager : MonoBehaviour
{
    [SerializeField] private GameObject pauseMenu;

    [SerializeField] private GameObject pauseBtn;

    [SerializeField] private CameraScript camera1;

    private void Update()
    {
        if (Input.GetKeyUp(KeyCode.Escape))
        {
            TogglePause();
        }
    }

    public void ExitGame()
    {
        Application.Quit();
    }

    public void TogglePause()
    {
        camera1.ToggleMouseInput();
        pauseMenu.SetActive(!GameManager.Instance.isPaused);
        GameManager.Instance.isPaused = !GameManager.Instance.isPaused;

        pauseBtn.SetActive(!GameManager.Instance.isPaused);

        Time.timeScale = GameManager.Instance.isPaused ? 0f : 1f;
    }
}