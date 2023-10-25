using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonosingletonTemp<SoundManager>
{
    // Start is called before the first frame update
    public AudioSource musicSource;
    public AudioSource sfxSource;
    
    public void Init()
    {
        Debug.Log("SoundManager Init");
    }
    void PlayMusic(AudioClip clip)
    {
        musicSource.clip = clip;
        musicSource.Play();
    }
    
    void EnableSFX(AudioClip clip)
    {
        sfxSource.clip = clip;
        sfxSource.enabled = true;
    }
    
    void DisableSFX()
    {
        sfxSource.enabled = false;
    }

    private void Start()
    {
        PlayMusic(musicSource.clip);
    }

    private void Update()
    {
        if (Input.GetAxisRaw("Horizontal") != 0 || Input.GetAxisRaw("Vertical") != 0)
        {
            EnableSFX(sfxSource.clip);
        }
        else
        {
            DisableSFX();
        }
    }
}
