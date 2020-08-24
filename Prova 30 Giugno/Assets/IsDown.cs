using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;
using UnityEngine.UI;

public class IsDown : MonoBehaviour
{
    public static int punteggio;
    
    public Text point;
    public GameObject cube;
    private int isDown;

    // Start is called before the first frame update
    void Start()
    {
        punteggio = 5;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(cube.GetComponent<Transform>().localRotation.x);
        if ((cube.GetComponent<Transform>().localRotation.x > -0.10f) && (isDown==0))
        {
            isDown = 1;
            punteggio--;
        }
        point.text = "Blocchi in piedi = " + punteggio;
    }
}
