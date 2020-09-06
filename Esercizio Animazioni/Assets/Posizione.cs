using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Posizione : MonoBehaviour
{
    public Text txt_posizione;
    public Text txt_angolo;
    public Image slice;

    // Start is called before the first frame update
    void Start()
    {
        txt_angolo.text = "Angolo : 1";
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void primo_quarto()
    {
        slice.fillAmount = 0f;
        txt_angolo.text = "Angolo : 1";
    }

    public void secondo_quarto()
    {
        slice.fillAmount = 0.25f;
        txt_angolo.text = "Angolo : 2";
    }

    public void terzo_quarto()
    {
        txt_angolo.text = "Angolo : 3";
    }

    public void quarto_quarto()
    {
        txt_angolo.text = "Angolo : 4";
    }
}
