using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VolumeManager : MonoBehaviour
{
    private AudioListener listener;
    public Slider volumeSlider;
    void Start()
    {
        AudioListener listener = GetComponent<AudioListener>();
    }
    public void VolumeUpdate()
    {
        AudioListener.volume = volumeSlider.value;
    }
}
