using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioEngine : MonoBehaviour
{
    public static AudioEngine instance = null;
    public AudioSource musicStream;
    public AudioSource soundStream;

    public float BPM = 0f;
    public float Chrono = 0f;

    public ShapeManager shapeManager;
    public AnimatedPlatformManager animatedPlatformManager;
    public BackgroundBehaviour backgroundBehaviour;


    private void Start()
    {
        shapeManager.ShapeBeatStart("backgroundShape");
        animatedPlatformManager.ShapeBeatStart("PlatformAnimated");
        backgroundBehaviour.ColorWithBeat();

    }

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
    void FixedUpdate()
    {
        // Chrono used with the BPM of the music
        // Chrono += Time.fixedDeltaTime;

        if (Chrono >= 60 / BPM)
        {
        //    Chrono = 0f;
        }
        else if (Chrono <= 60 / BPM)
        {

        }
    }
}
