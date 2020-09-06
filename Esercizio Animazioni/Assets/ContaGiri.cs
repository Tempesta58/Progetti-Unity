using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ContaGiri : MonoBehaviour
{
    public Text txt;
    public int i;

    // Start is called before the first frame update
    void Start()
    {
        txt.text = "Numero giri: 0";
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AggiungiGiro()
    {
        i++;
        txt.text = "Numero giri: "+i; 
    }
}
