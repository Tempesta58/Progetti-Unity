using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Caduto : MonoBehaviour
{
    public GameObject cil;
    public Text txt;

    private static int i;
    private int flag;

    // Start is called before the first frame update
    void Start()
    {
        flag = 0;
        i = 0;
        txt.text = "Cilindri caduti = " + i;
    }

    // Update is called once per frame
    void Update()
    {
        if ((flag==0)&&(cil.GetComponent<Transform>().position.y < 0.5f))
        {
            i++;
            flag = 1;
            txt.text = "Cilindri caduti = " + i;
            Destroy(cil);
        }
    }
}
