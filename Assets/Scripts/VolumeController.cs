using UnityEngine;
using System.Collections;
using System;

public class VolumeController : MonoBehaviour {
    private AudioSource AS;

    public enum MyEnumListy { Music, Sound}
    public MyEnumListy TypeOfAudio;

    void Start()
    {
        AS = GetComponent<AudioSource>();
    }
    void Update()
    {
        switch (TypeOfAudio)
        {
            case MyEnumListy.Music:
                AS.volume = SoundController.MusicVolume;
                break;
            case MyEnumListy.Sound:
                    AS.volume = SoundController.SoundVolume;
                    break;
            default:
                Debug.Log("NOTHING");
                break;
        }
    }
}
