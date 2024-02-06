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

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

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
    }

    public void Check()
    {
        panel.SetActive(false);
    }
}