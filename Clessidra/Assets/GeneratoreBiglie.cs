using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GeneratoreBiglie : MonoBehaviour
{
    public GameObject sfera;
    public Text txt;
    private int i;
    private double tempo;

    // Start is called before the first frame update
    void Start()
    {
        i = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("g"))
        {
            genera();
            i++;
        }

        tempo += Time.deltaTime;

        if (tempo > 2)
        {
            i++;
            genera();
            tempo = 0f;
        }


        txt.text = "Sfere spawnate: " + i;
    }

    public void genera()
    {
        Instantiate(sfera, new Vector3(Random.Range(1, -1), Random.Range(10, 12), Random.Range(1, -1)), Quaternion.identity);
    }

}
