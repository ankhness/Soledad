using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuAjustes : MonoBehaviour
{
    [SerializeField] Slider volumeSlider;

    public void Start () {
        if(!PlayerPrefs.HasKey("musicVolume")){
            PlayerPrefs.SetFloat("musicVolume", 1);
            Load();
        }

        else {
            Load();
        }
    }

    public void Change () {
        Screen.fullScreen = !Screen.fullScreen;
        print("changed screen mode");
    }

    public void ChangeVolume () {
        AudioListener.volume = volumeSlider.value;
        Save();
    }

    private void Load(){
        volumeSlider.value = PlayerPrefs.GetFloat("musicVolume");
    }

    private void Save () {
        PlayerPrefs.SetFloat("musicVolume", volumeSlider.value);
    }
}
