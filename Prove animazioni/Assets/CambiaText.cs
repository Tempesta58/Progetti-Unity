using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CambiaText : MonoBehaviour
{
    // Start is called before the first frame update

    public Text txt;
    private int i;

    void Start()
    {
       i = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void cambiatesto()
    {
        i++;
        txt.text = "ciao mondo"+i;
    }  
}
