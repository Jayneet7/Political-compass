using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animation : MonoBehaviour
{
    public GameObject Redcard;
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
        LeanTween.move(Redcard,new Vector3 (1682, 905, 0),2.0f);
    }
}
