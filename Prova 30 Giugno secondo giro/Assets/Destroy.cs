using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    public GameObject me;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    //Prendo dall'oggetto Collision il gameobjetc poi il nome e lo comparo,
    //se si trova con distruggo l'oggetto passato prima come attributo di classe.
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name.CompareTo("Cilindro") == 0)
            Destroy(me);
    }
}
