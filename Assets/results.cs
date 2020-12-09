using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
[System.Serializable]

public class results : MonoBehaviour
{

    public int agree1 = 0;
    public int disagree1 = 0;

    public void agree()
    {
        agree1 = agree1 + 1;
    }
    public void disagree()
    {
        disagree1 = disagree1 + 1;
    }

    public void mainmenu()
    {
        SceneManager.LoadScene(0);
    }

    public void nextscene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

}