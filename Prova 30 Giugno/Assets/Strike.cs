using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Strike : MonoBehaviour
{
    public GameObject img;
    public GameObject txt;
    public GameObject cil;


    // Start is called before the first frame update
    void Start()
    {
        img.SetActive(false);
        txt.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if (cil.GetComponent<Transform>().position.y < 0f)
        {
            img.SetActive(true);
            txt.SetActive(false);
        }
    }
}
