using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ComputeNumbers : MonoBehaviour
{
    public Text result;
    public InputField varA;
    public InputField varB;
    public Button Reset_Btn;
    public Button SubNumbers_Btn;




    // Start is called before the first frame update
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {

    }

    private int SubNumbers()
    {
        int a = int.Parse(varA.text);
        int b = int.Parse(varB.text);
        return a - b;
    }

    public void SetResult()
    {

        result.text = SubNumbers().ToString();
        varA.interactable = false;
        varB.interactable = false;
        SubNumbers_Btn.interactable = false;
        Reset_Btn.interactable = true;
    }

    public void ResetGui()
    {
        result.text = "Result";
        varA.text = "0";
        varB.text = "0";
        varA.interactable = true;
        varB.interactable = true;
        SubNumbers_Btn.interactable = true;
        Reset_Btn.interactable = false;

    }

}
