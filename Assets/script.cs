using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class script : MonoBehaviour
{
    [SerializeField] Slider volumeSlider;

    [SerializeField] Toggle muteAudio;


    public void goSettingMenu()
    {
        Debug.Log("Menuju ke menu settings");
    }
    public void outSettingMenu()
    {
        Debug.Log("keluar dari settng menu dan Kembali ke Main Menu");
    }
    public void PlayGame()
    {
        // SceneManager.LoadScene(1);
        Debug.Log("Menuju ke Scene Game Baru");
    }

    public void Back()
    {
        // SceneManager.LoadScene(0);
        Debug.Log("Kembali ke Main Menu");
    }

    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Kamu telah keluar dari game");
    }

    public void setVolume()
    {
        AudioListener.volume = volumeSlider.value;
        Debug.Log("Volume Saat ini " + Mathf.Round(AudioListener.volume * 100));
    }
    public void mute()
    {
        if (muteAudio.isOn)
        {
            AudioListener.volume = 0;
            volumeSlider.interactable = false;
            Debug.Log("Audio Mati");
        }
        else
        {
            AudioListener.volume = volumeSlider.value;
            volumeSlider.interactable = true;
            Debug.Log("Audio Menyala");
        }
    }
}

