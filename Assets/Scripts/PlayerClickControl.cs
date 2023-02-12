using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class PlayerClickControl : MonoBehaviour
{
    public GameObject objectHide; //Objeto a ser escondido.
    public UnityEvent onClick;



    private void OnMouseDown() //Evento do click do player sobre o Objeto
    {
        onClick.Invoke();
        if (objectHide.activeSelf)
        {
            objectHide.SetActive(false); //Visibilidade do objeto (false)
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
        else
        {
            objectHide.SetActive(true); //Visibilidade do objeto (true)
        }
    }
}
