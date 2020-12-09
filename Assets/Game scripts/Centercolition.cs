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

    public GameObject exitTextA;
    public GameObject exitTextB;
    public GameObject exitTextC;
    public GameObject exitTextD;
    
    
    public GameObject selectcard;

    public bool allin = false;

    void Start()
    {
        enterTextA.SetActive(false);
        enterTextB.SetActive(false);
        enterTextC.SetActive(false);
        enterTextD.SetActive(false);
        
    
        exitTextA.SetActive(false); 
        exitTextB.SetActive(false); 
        exitTextC.SetActive(false); 
        exitTextD.SetActive(false);

    }

    private void Update()
    {
        if (allin == false)
        {
            
            selectcard.SetActive(true);
        }
        
    }

    private void OnTriggerEnter2D(Collider2D carda)
    {
        
        if(carda.gameObject.tag == "Card A")
        {
            enterTextA.SetActive(true);
            exitTextA.SetActive(false);
        }
        if (carda.gameObject.tag == "Card B")
        {
            enterTextB.SetActive(true);
            exitTextB.SetActive(false);
        }
        if (carda.gameObject.tag == "Card C")
        {
            enterTextC.SetActive(true);
            exitTextC.SetActive(false);
        }
        if (carda.gameObject.tag == "Card D")
        {
            enterTextD.SetActive(true);
            exitTextD.SetActive(false);
            allin = false;
        }
    }

    private void OnTriggerExit2D(Collider2D carda)
    {
        if (carda.gameObject.tag == "Card A")
        {    
            enterTextA.SetActive(false);
            exitTextA.SetActive(true);
        }
        if (carda.gameObject.tag == "Card B")
        {
            enterTextB.SetActive(false);
            exitTextB.SetActive(true);
        }
        if (carda.gameObject.tag == "Card C")
        {
            enterTextC.SetActive(false);
            exitTextC.SetActive(true);
        }
        if (carda.gameObject.tag == "Card D")
        {
            enterTextD.SetActive(false);
            exitTextD.SetActive(true);

        }
    }

}
