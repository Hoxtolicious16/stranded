using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SteuerHerz : MonoBehaviour
{
    public Transform[] herzen;
    int lp;
    // Start is called before the first frame update
    void Start()
    {
        lp=herzen.Length-1;
    }

    // Update is called once per frame
    public void takeDamage()
    {
        if(lp==0)
        {
            SceneManager.LoadScene("GameOver");
        }
        lp--;
        for(int i=0; i<herzen.Length; i++)
        {
            herzen[i].gameObject.SetActive(lp>i);
        }
        
    }
}