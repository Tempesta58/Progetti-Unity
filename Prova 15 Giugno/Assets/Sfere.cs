using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sfere : MonoBehaviour
{
    public GameObject np;
    public GameObject button;
    public GameObject go;
    public GameObject ball1;
    public GameObject ball2;
    public GameObject ball3;


    // Start is called before the first frame update
    void Start()
    {
        button.SetActive(false);
        np.SetActive(false);
        go.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if ((ball1.GetComponent<Transform>().position.y < 0) && (ball2.GetComponent<Transform>().position.y < 0) && (ball3.GetComponent<Transform>().position.y < 0))
        {
            button.SetActive(true);
            np.SetActive(true);
            go.SetActive(true);
        }
    }
}
