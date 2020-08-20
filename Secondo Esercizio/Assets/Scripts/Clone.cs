using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class Clone : MonoBehaviour
{
    public GameObject obj;
    public int n=20;

    public GameObject[] clones = new GameObject[100];

    // Start is called before the first frame update
    void Start()
    {
       for(int i=0;i<=n;i++){
            clones[i] = Instantiate(obj,new Vector3(transform.position.x + (float) Random.Range(0,5),transform.position.y + (float) Random.Range(0,5), transform.position.z + (float) Random.Range(0,5)),Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i <= n; i++)
        {
            Color c = clones[i].GetComponent<Renderer>().material.color;
            c.a = (float) Random.Range(0,255) * Time.deltaTime;
            clones[i].GetComponent<Renderer>().material.color = c;
        }
    }

}
