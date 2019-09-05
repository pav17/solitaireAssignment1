using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{

    public AudioClip Track1;
    public AudioClip Track2;
    public AudioClip Track3;
    public AudioClip Track4;
    public AudioClip Track5;
    public AudioClip Track6;
    public AudioClip Track7;
    int nextClip = 0;
    AudioSource Source;
    AudioClip[] Tracks;
    // Start is called before the first frame update
    void Start()
    {
        Source = gameObject.GetComponent<AudioSource>();
        Tracks = new AudioClip[] {Track1, Track2, Track3, Track4, Track5, Track6, Track7};
    }

    // Update is called once per frame
    void Update()
    {
        if(Source.isPlaying == false)
        {
            Source.clip = Tracks[nextClip];
            Source.Play();
            nextClip++;
        }
        if(nextClip > 6)
        {
            nextClip = 0;
        }
    }
}
