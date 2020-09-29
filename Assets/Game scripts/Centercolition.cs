using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Centercolition : MonoBehaviour
{
    
    public GameObject enterTextA;
    public GameObject enterTextB;
    public GameObject enterTextC;
    public GameObject enterTextD;
    

    void Start()
    {
        enterTextA.SetActive(false);
        enterTextB.SetActive(false);
        enterTextC.SetActive(false);
        enterTextD.SetActive(false);
    

    }

    private void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D carda)
    {
        
        if(carda.gameObject.tag == "Card A")
        {
            enterTextA.SetActive(true);
        }
        if (carda.gameObject.tag == "Card B")
        {
            enterTextB.SetActive(true);
        }
        if (carda.gameObject.tag == "Card C")
        {
            enterTextC.SetActive(true);
        }
        if (carda.gameObject.tag == "Card D")
        {
            enterTextD.SetActive(true);
        }
        
    }



}
