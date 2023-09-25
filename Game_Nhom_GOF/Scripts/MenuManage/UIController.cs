using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    public Slider _musicSlider, _sfxSlider;
    public void MusicVolume()
    {
        AudioManage.instance.MusicVolume(_musicSlider.value);
    }

    public void SfxVolume()
    {
        AudioManage.instance.SFXVolume(_sfxSlider.value);
    }
}
