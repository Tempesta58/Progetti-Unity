using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class Caduto: MonoBehaviour
{
    public static int c;
    public GameObject tes;
    public Text txt;
    public int flag;


    // Start is called before the first frame update
    void Start()
    {
        flag = 0;
        c = 0;
        txt.text = "Blocchi caduti: " + c;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(tes.GetComponent<Transform>().localRotation.z);
        if ((tes.GetComponent<Transform>().localRotation.z >= 0.6f) && (flag == 0)){
            flag = 1;
            c++;
            txt.text = "Blocchi caduti: " + c;
        }
    }
}
