using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InfoClick : MonoBehaviour
{
    // Start is called before the first frame update
    public Animator _animator;
    public Button infoButton;
    public GameObject buttonGameobject;
    void Start()
    {
        infoButton.onClick.AddListener(TurnOn);
    }
    private void TurnOn()
    {
        StartCoroutine(TurnOnCoroutine());
    }
    IEnumerator TurnOnCoroutine()
    {

        _animator.gameObject.SetActive(true);
        yield return new WaitForSeconds(1);
        infoButton.onClick.RemoveAllListeners();    
        infoButton.onClick.AddListener(TurnOff);
    }
    private void TurnOff()
    {
        StartCoroutine(TurnOffCoroutine());
    }
    IEnumerator TurnOffCoroutine()
    {
        _animator.Play("Question_Mark_Off");
        yield return new WaitForSeconds(1);
        _animator.gameObject.SetActive(false);
        infoButton.onClick.RemoveAllListeners();
        infoButton.onClick.AddListener(TurnOn);

    }

}
