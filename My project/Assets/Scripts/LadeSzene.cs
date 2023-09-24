using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LadeSzene : MonoBehaviour
{
    // Start is called before the first frame update
    public void Scem1()
    {
        SceneManager.LoadScene("GAMEPLAY SCENE!");
    }
    public void Scem2()
    {
        SceneManager.LoadScene("Startbildschirm");
    }
    public void Scem3()
    {
        SceneManager.LoadScene("Charakterauswahl");
    }
}

