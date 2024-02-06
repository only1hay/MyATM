using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class DirectInputt : MonoBehaviour
{
    public TMP_InputField directInput;
    public TMP_Text cash;
    public TMP_Text balance;
    public GameObject panel;
    public GameObject DScene;
    public GameObject WScene;

    public void DirectPlus()
    {
        bool _DScene = DScene.activeSelf;
        bool _WScene = WScene.activeSelf;

        int Intbalance = int.Parse(balance.text);
        int IntCash = int.Parse(cash.text);
        int IntDirectInput = int.Parse(directInput.text);

        if(_DScene==true)
        {
            if (IntCash >= IntDirectInput)
            {
                Intbalance += IntDirectInput;
                IntCash -= IntDirectInput;
            }
            else
            {
                panel.SetActive(true);
            }
        }
        else if(_WScene==true)
        {
            if (Intbalance >= IntDirectInput)
            {
                Intbalance -= IntDirectInput;
                IntCash += IntDirectInput;
            }
            else
            {
                panel.SetActive(true);
            }
        }
       

        balance.text = Intbalance.ToString();
        cash.text = IntCash.ToString();
        directInput.text = "";
    }

}
