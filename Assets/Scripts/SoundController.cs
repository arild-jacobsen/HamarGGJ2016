using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class SoundController : MonoBehaviour {
    public static float MusicVolume = 0.75f, SoundVolume = 0.75f;

    public static bool MusicIsMuted = false, SoundIsMuted = false;

    public AudioClip[] Music;
    public int CurrentSceneMusicTrack;

    private AudioSource MainMusicAudio;


    public static SoundController Instance;

    void Awake()
    {
        if(Instance)
                 DestroyImmediate(gameObject);
             else
             {
            DontDestroyOnLoad(gameObject);
            Instance = this;
        }
    }


    void Start()
    {
        MainMusicAudio = GetComponent<AudioSource>();
        MainMusicAudio.Stop();
    }
    void Update()
    {
        if (CurrentSceneMusicTrack != Application.loadedLevel) { MainMusicAudio.Stop();
            CurrentSceneMusicTrack = Application.loadedLevel;
        }
        if (MusicIsMuted) MainMusicAudio.mute = true;
        else MainMusicAudio.mute = false;


        MainMusicAudio.volume = MusicVolume;
        if (!MainMusicAudio.isPlaying) {
            MainMusicAudio.clip = Music[CurrentSceneMusicTrack];
            MainMusicAudio.Play();
        }
    }
    public void ToggleMusic()
    {
        MusicIsMuted = !MusicIsMuted;
    }
    public void ToggleSound()
    {
        SoundIsMuted = !SoundIsMuted;
    }
}
