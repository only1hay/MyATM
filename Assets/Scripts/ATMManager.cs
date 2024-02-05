using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ATMManager : MonoBehaviour
{
    public static ATMManager I;
    public GameObject baseObject;
    public GameObject depositScene;

    public void Awake()
    {
        I = this;
    }

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
