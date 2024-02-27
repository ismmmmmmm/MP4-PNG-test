using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class TicTacToeScript : MonoBehaviour
{
    // Start is called before the first frame update
    public Button[] buttons;
    public TextMeshProUGUI[] textMesh;
    private int currentValue;
    private bool doneFirst=false;
    void Start()
    {
        for (int i = 0; i < buttons.Length; i++)
        {
            int index =i;
            buttons[i].onClick.AddListener(() => SetValue(index));
        }
    }
    public void SetValue(int index)
    {
        currentValue = index;
        doneFirst = doneFirst ? false : true;
        textMesh[currentValue].text = doneFirst ? "X" : "O";
        ColorBlock buttonColors = buttons[currentValue].colors;
        buttonColors.normalColor = doneFirst ? Color.red : Color.blue;
        buttons[currentValue].colors = buttonColors;

        Debug.Log(currentValue);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
