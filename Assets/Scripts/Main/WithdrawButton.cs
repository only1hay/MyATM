using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WithdrawButton : MonoBehaviour
{
    public GameObject mainObject;
    public GameObject withdrawScene;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GoWithdraw()
    {
        mainObject.SetActive(false);
        withdrawScene.SetActive(true);
    }
}
