using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DepositButton : MonoBehaviour
{
    public GameObject baseObject;
    public GameObject depositScene;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GoDeposit()
    {
        baseObject.SetActive(false);
        depositScene.SetActive(true);
    }

}
