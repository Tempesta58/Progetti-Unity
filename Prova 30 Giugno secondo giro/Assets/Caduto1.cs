using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Caduto1 : MonoBehaviour
{

    public GameObject cil;
    public GameObject txt;
    public GameObject img;

    // Start is called before the first frame update
    void Start()
    {
        txt.SetActive(true);
        img.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(cil.GetComponent<Transform>().position.y < 0)
        {
            txt.SetActive(false);
            img.SetActive(true);
        }
    }
}
