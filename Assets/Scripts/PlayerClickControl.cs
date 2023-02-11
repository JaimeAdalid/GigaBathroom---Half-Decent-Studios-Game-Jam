using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerClickControl : MonoBehaviour
{
    public GameObject objectHide; //Objeto a ser escondido.

    private void OnMouseDown() //Evento do click do player sobre o Objeto
    {
        if (objectHide.activeSelf)
        {
            objectHide.SetActive(false); //Visibilidade do objeto (false)
        }
        else
        {
            objectHide.SetActive(true); //Visibilidade do objeto (true)
        }
    }
}
