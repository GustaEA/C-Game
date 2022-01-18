using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class UISound : MonoBehaviour
{
    [SerializeField] AudioClip buttonAudio;

    AudioSource audioSource;

    AudioSource AudioSource => audioSource == null ? audioSource = GetComponent<AudioSource>() : audioSource;


    public void ButtonAudio()
    {
        PlayMusic(buttonAudio);
    }
    void PlayMusic(AudioClip clip)
    {
        AudioSource.clip = clip;
        AudioSource.loop = false;
        AudioSource.Play();
    }

    void StopMusic()
    {
        AudioSource.Stop();
    }
}
