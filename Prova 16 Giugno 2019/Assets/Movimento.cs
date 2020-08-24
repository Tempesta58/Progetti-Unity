using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimento : MonoBehaviour
{
    public GameObject sphere;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        while (Input.GetKeyDown(KeyCode.W))
        {
            float x=sphere.GetComponent<Transform>().position.x;
            x=x+0.1f;
            sphere.GetComponent<Transform>().position = new Vector3(x, sphere.GetComponent<Transform>().position.y, sphere.GetComponent<Transform>().position.z);
        }
    }
}
