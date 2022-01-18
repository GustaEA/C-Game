using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class MusicPlayer : MonoBehaviour
{
    [SerializeField] AudioClip starMenuMusic;
    [SerializeField] AudioClip mainTrackMusic;
    [SerializeField] AudioClip gameOverMusic;

    AudioSource audioSource;

    AudioSource AudioSource => audioSource == null ? audioSource = GetComponent<AudioSource>() : audioSource;


    public void StartMenuMusic()
    {
        PlayMusic(starMenuMusic);
    }

    public void StartMainMusic()
    {
        PlayMusic(mainTrackMusic);
    }

    public void StartGameOverMusic()
    {
        PlayMusic(gameOverMusic);
    }

    void PlayMusic(AudioClip clip)
    {
        AudioSource.clip = clip;
        AudioSource.loop = true;
        AudioSource.Play();
    }

    void StopMusic()
    {
        AudioSource.Stop();
    }
}
