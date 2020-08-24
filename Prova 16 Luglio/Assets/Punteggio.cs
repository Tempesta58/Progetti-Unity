using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Punteggio : MonoBehaviour
{
    public static int punteggio;

    public Text gui;
    public GameObject cil;
    public Material mat;

    private int flag;

    // Start is called before the first frame update
    void Start()
    {
        punteggio = 0;
        flag = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if ((cil.GetComponent<Transform>().position.z > 140f) && (flag==0))
        {
            cil.GetComponent<MeshRenderer>().material = mat;
            punteggio++;
            flag = 1;
        }
        gui.text = "Ghiaccio cauto = " + punteggio;

    }
}
