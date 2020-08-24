using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Extra : MonoBehaviour
{
    private Random rand;
    public InputField input;
    public GameObject ball;

    public void createSphere()
    {
        int n=int.Parse(input.text);
        Debug.Log(n);
        for (int i = 0; i < n; i++) { 
            Instantiate(ball, new Vector3(Random.Range(-6, 6), Random.Range(1, 10), Random.Range(-6, 6)), Quaternion.identity);
        }
    }
}
