using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Jobs;
using UnityEngine.UI;

public class lesson1_Slide9 : Audio_Narrator{
    // Start is called before the first frame update
    public Button[] buttons;
    public int currentValue;
    private int levelCount;
    public Animator animator;
    void Start()
    {
        for (int i = 0; i < buttons.Length; i++)
        {
            int index = i;
            buttons[i].onClick.AddListener(()=>SetValue(index));
        }
        StartCoroutine(StartSceneCoroutine());
    }

    private IEnumerator StartSceneCoroutine()
    {
        yield return new WaitForSeconds(1);
        SetAudioNarration(levelCount);
        yield return new WaitForSeconds(clip[levelCount].length);
    }

    private void SetValue(int index)
    {
        currentValue = index;

    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
