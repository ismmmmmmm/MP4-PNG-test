using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Audio_Narrator : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip[] clip;
    public Button nextButton;
    void Start()
        {
        
        }

    public void SetAudioNarration(int audioCount) 
        {
            audioSource.clip = clip[audioCount];
            audioSource.Play();
        }
    void Update()
        {
        
        }
}