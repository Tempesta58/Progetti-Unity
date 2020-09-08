using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generatore : MonoBehaviour
{
    public GameObject cil;
    private double tempo;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.G))
        {
            genera();
        }

        tempo += Time.deltaTime;

        if (tempo > 5)
        {
            genera();
            tempo = 0f;
        }
    }

    public void genera()
    {
        Instantiate(cil, new Vector3(0.04f, 10.64f, 17.38f), new Quaternion(0, 0, 45, 45));
    }
}
