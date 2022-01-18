using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class PlayerAudioController : MonoBehaviour
{
    AudioSource audioSource;

    AudioSource AudioSource => audioSource == null ? audioSource = GetComponent<AudioSource>() : audioSource;

    [SerializeField] AudioClip jumpSound;
    [SerializeField] AudioClip rollSound;

    public void PlayJumpSound()
    {
        Play(jumpSound);
    }

    public void PlayRollSound()
    {
        Play(rollSound);
    }

    void Play(AudioClip clip)
    {
        AudioSource.clip = clip;
        AudioSource.loop = false;
        AudioSource.Play();
    }
}
