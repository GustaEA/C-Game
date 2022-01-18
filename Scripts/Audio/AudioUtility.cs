using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class AudioUtility 
{
    public static void PlayAudioCue(AudioSource source, AudioClip clip)
    {
        source.clip = clip;
        source.loop = false;
        source.Play();
    }
}
