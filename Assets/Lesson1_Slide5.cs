using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Lesson1_Slide5 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GoAct1()
    {
        SceneManager.LoadScene("Act1 1");
    }
    public void GoAct2()
    {
        SceneManager.LoadScene("Act1 2");
    }
    public void GoAct3()
    {
        SceneManager.LoadScene("Act1 3");
    }
}
