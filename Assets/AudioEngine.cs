using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioEngine : MonoBehaviour
{
    public static AudioEngine instance = null;
    public AudioSource musicStream;
    public AudioSource soundStream;

    void Awake()
    {
        if(instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        } else
        {
            Destroy(gameObject);
        }
    }

    public void PlaySound(AudioClip soundClipToPlay)
    {
        soundStream.clip = soundClipToPlay;
        soundStream.Play();
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
