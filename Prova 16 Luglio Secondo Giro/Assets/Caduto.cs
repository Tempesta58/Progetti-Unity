using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class Caduto : MonoBehaviour
{
    public GameObject cil;
    public Material mat;
    public int i;
    public Text txt;
    public int flag = 0;

    // Start is called before the first frame update
    void Start()
    {
        i = 0;
        txt.text = "Giacchio caduto= " + i;
    }

    // Update is called once per frame
    void Update()
    {
        if((cil.GetComponent<Transform>().position.x < -1) && (flag==0))
        {
            i++;
            flag = 1;
            cil.GetComponent<MeshRenderer>().material = mat;

        }
        txt.text = "Giacchio caduto= " + i;

    }
}
