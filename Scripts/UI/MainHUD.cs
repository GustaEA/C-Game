using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class MainHUD : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI scoreText;
    [SerializeField] TextMeshProUGUI metersText;
    [SerializeField] GameMode gameMode;

    private static bool gameIsPaused = false;

    [SerializeField] GameObject HUD;
    [SerializeField] GameObject PauseUI;
    [SerializeField] GameObject StartUI;

    private void Awake()
    {
        StartUI.SetActive(true);
        PauseUI.SetActive(false);
        HUD.SetActive(false);
    }
    private void LateUpdate()
    {
        scoreText.text = $"Score: {gameMode.Score}";
        metersText.text = $"{gameMode.Meters}m";
    }

    public void PlayButton()
    {
        StartUI.SetActive(false);
        HUD.SetActive(true);
        gameMode.StartGame();
    }

    void PauseButton()
    {
        Pause();
    }

    void ResumeButton()
    {
        Resume();
    }

    public void Resume()
    {
        HUD.SetActive(true);
        PauseUI.SetActive(false);
        gameMode.ResumeGame();
        gameIsPaused = false;
    }

    public void Pause()
    {
        HUD.SetActive(false);
        PauseUI.SetActive(true);
        gameMode.PauseGame();
        gameIsPaused = true;
    }
}
