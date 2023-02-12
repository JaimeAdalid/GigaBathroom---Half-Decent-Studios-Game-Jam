using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GiveFoodScript : MonoBehaviour
{

    public GameObject food01;
    public GameObject food02;
    public GameObject food03;
    public int food = 3;
    public bool Alimentar = true;


    // Start is called before the first frame update
    private void OnMouseDown() //Evento do click do player sobre o Objeto
    {

        food--;

        if (food01.activeSelf && food == 3)
        {
            food01.SetActive(false); //Visibilidade do objeto (false)
            Alimentar = false;
        }
        
        if (food02.activeSelf && food == 2)
        {
            food02.SetActive(false); //Visibilidade do objeto (false)
        }
     
        if (food03.activeSelf && food == 1)
        {
            food03.SetActive(false); //Visibilidade do objeto (false)
        }
        
    }
}
