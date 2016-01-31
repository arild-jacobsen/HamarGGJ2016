using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Options : MonoBehaviour {
    public Text MusicVolumeText, SoundVolumeText;
    public Slider MusicSlider, SoundSlider;

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        SoundController.MusicVolume = MusicSlider.value;
        SoundController.SoundVolume = SoundSlider.value;
        int v2 = (int)(SoundController.SoundVolume * 100);
        int v1 = (int)(SoundController.MusicVolume * 100);
        SoundVolumeText.text = "Sound Volume: " + (v2).ToString() + "%";
        MusicVolumeText.text = "Music Volume: " + (v1).ToString() + "%";
    }
}
