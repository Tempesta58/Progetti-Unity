using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generatore_Muro : MonoBehaviour
{
    public GameObject block;
    public int width = 10;
    public int height = 4;

    // Start is called before the first frame update
    void Start()
    {
        for (int y = 0; y < height; ++y)
        {
            for (int x = 0; x < width; ++x)
            {
                Instantiate(block, new Vector3(transform.position.x + 1 + x, transform.position.y + y, transform.position.z), Quaternion.identity);
                //Quaternion.Euler(new Vector3(transform.rotation.x, transform.rotation.y + y * 10, transform.rotation.z));
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
