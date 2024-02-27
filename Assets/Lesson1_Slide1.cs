using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson1_Slide1 : Audio_Narrator
{
    public int audioCount;
    void Start()
    {
        StartCoroutine(StartSceneCoroutine());
    }

    private IEnumerator StartSceneCoroutine()
    {
        for(int i = 0; i < audioCount; i++)
        {
            SetAudioNarration(i);
            yield return new WaitForSeconds(clip[i].length+1);
        }
        nextButton.gameObject.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
