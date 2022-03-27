using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [SerializeField] private AudioClip[] audio;
    AudioSource audioSource;

    public static AudioManager instance;

    private void Awake()
    {
        instance = this;
        audioSource = GetComponent<AudioSource>();
    }


    public void audiodie()
    {
        audioSource.PlayOneShot(audio[0]);
    }

    public void audiocoin()
    {
        audioSource.PlayOneShot(audio[1]);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
