using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Slide_Manager : MonoBehaviour
{
    // Start is called before the first frame update
    public Animator transitionAnim;
    public Button buttonImage;
    public GameObject[] canvasSlide;
    private int canvasCount;

    void Start()
    {
        buttonImage.onClick.AddListener(NextPage);
        StartCoroutine(StartSceneCoroutine());
    }

    private IEnumerator StartSceneCoroutine()
    {
        yield return new WaitForSeconds(1);
            
    }

    private void NextPage()
    {
        StartCoroutine(NextPageCoroutine());
    }
    private IEnumerator NextPageCoroutine()
    {
        canvasCount++;
        transitionAnim.Play("Transition");
        yield return new WaitForSeconds(2f);
        canvasSlide[canvasCount - 1].gameObject.SetActive(false);
        canvasSlide[canvasCount].gameObject.SetActive(true);
        transitionAnim.Play("Transition_Reverse");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
