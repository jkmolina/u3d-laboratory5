using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AudioManager : MonoBehaviour
{
    public AudioSource startMusic;
    public Slider volume;
    // Start is called before the first frame update

    void Start()
    {
        startMusic = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        startMusic.volume = volume.value;
    }
}
