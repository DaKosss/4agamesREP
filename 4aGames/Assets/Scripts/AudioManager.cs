using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class AudioManager : MonoBehaviour
{

    public AudioMixer _MasterMixer;

    public void SetMasterVolume(Slider volume)
    {
        _MasterMixer.SetFloat("Master", volume.value);
    }

    public void SetBGMVolume(Slider volume)
    {
        _MasterMixer.SetFloat("bgm", volume.value);
    }

    public void SetSFXVolume(Slider volume)
    {
        _MasterMixer.SetFloat("sfx", volume.value);
    }

}