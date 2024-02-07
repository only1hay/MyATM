using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ButtonManager : MonoBehaviour
{
    public TMP_Text cash;
    public TMP_Text balance;
    public GameObject panel;
    public GameObject DScene;
    public GameObject WScene;

    public void PlusMoney(int money)
    {
        bool _DScene = DScene.activeSelf;
        bool _WScene = WScene.activeSelf;

        int Intbalance = int.Parse(balance.text);
        int IntCash = int.Parse(cash.text);

        if (_DScene == true)
        {
            if (IntCash >= money)
            {
                Intbalance += money;
                IntCash -= money;
            }
            else
            {
                panel.SetActive(true);
            }
        }
        else if (_WScene == true)
        {
            if (Intbalance >= money)
            {
                Intbalance -= money;
                IntCash += money;
            }
            else
            {
                panel.SetActive(true);
            }
        }
        balance.text = Intbalance.ToString();
        cash.text = IntCash.ToString();

        //balance.text = string.Format("{0:#,0}", Intbalance);
    }

    public void Check()
    {
        panel.SetActive(false);
    }
}
