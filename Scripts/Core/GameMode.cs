using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameMode : MonoBehaviour
{
    [SerializeField] private float reloadGameDelay = 3;

    [SerializeField] bool start = false;

    [SerializeField] MusicPlayer musicPlayer;

    [Header("Score")]
    [SerializeField] float BaseScoreMultiplier = 0.5f;
    float score;
    public int Score => Mathf.RoundToInt(score);

    float meters;
    public int Meters => Mathf.RoundToInt(player.TravelDistance);
    [SerializeField] PlayerController player;
    [SerializeField] PlayerAnimationController playerAnimationController;

    private void Awake()
    {
        SetWaitForStartGame();
    }

    private void Update()
    {
        RunScoreHUD();
    }

    void SetWaitForStartGame()
    {
        if (player != null && !start)
        {
            player.enabled = false;
        }

        musicPlayer.StartMenuMusic();
    }

    void RunScoreHUD()
    {
        if (player.enabled)
        {
            score += BaseScoreMultiplier * player.ForwardSpeed * Time.deltaTime;            
        }
    }

    public void StartGame()
    {
        musicPlayer.StartMainMusic();
        start = true;
        playerAnimationController.StartGameAnimation();
    }


    public void OnGameOver()
    {
        StartCoroutine(ReloadGameCoroutine());
    }    

    private IEnumerator ReloadGameCoroutine()
    {
        musicPlayer.StartGameOverMusic();
        start = false;
        yield return new WaitForSeconds(reloadGameDelay);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void PauseGame()
    {
        Time.timeScale = 0f;
    }

    public void ResumeGame()
    {
        Time.timeScale = 1f;
    }
}
