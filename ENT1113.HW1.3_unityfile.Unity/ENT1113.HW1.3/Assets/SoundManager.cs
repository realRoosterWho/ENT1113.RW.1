using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.Video;

public class SoundManager : MonosingletonTemp<SoundManager>
{
    // Start is called before the first frame update
    public AudioSource musicSource;
    public AudioSource sfxSource;
    
    public void Init()
    {
        Debug.Log("SoundManager Init");
    }
    public void PlayMusic(AudioClip clip)
    {
        musicSource.clip = clip;
        musicSource.volume = 0.3f;
        musicSource.Play();
    }
    
    public void EnableSFX(AudioClip clip, AudioMixerGroup mixer)
    {
        sfxSource.clip = clip;
        sfxSource.outputAudioMixerGroup = mixer;
        // 如果在播放，什么都不做，否则播放
        if (sfxSource.isPlaying)
        {
            return;
        }
        sfxSource.Play();
        sfxSource.enabled = true;
    }
    
    public void DisableSFX()
    {
        sfxSource.enabled = false;
    }

    private void Start()
    {
    }

    private void Update()
    {

    }
}
