using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animation : MonoBehaviour
{
    public GameObject redcard;
    public GameObject bluecard;
    public GameObject greencard;
    public GameObject purplecard;
    public GameObject ecoscale;
    public GameObject socscale;
    
    


    public GameObject Hidebutton;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    public void pressbutton() 
    {
        LeanTween.move(redcard,new Vector3 (-350, 250, 0),2.0f);
        LeanTween.move(bluecard,new Vector3 (350, 250, 0),2.0f);
        LeanTween.move(greencard,new Vector3 (-350, -250, 0),2.0f);
        LeanTween.move(purplecard,new Vector3 (350, -250, 0),2.0f);
        LeanTween.move(ecoscale,new Vector3 (0, 0, 0),2.0f);
        LeanTween.move(socscale,new Vector3 (0, -0, 0),2.0f);
        Hidebutton.SetActive(false);
    }
}
