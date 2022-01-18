using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class ObstacleDecoration : MonoBehaviour
{
    AudioSource audioSource;

    AudioSource AudioSource => audioSource == null ? audioSource = GetComponent<AudioSource>() : audioSource;
}
