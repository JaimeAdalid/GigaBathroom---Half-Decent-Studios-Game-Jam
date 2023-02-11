using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Som : MonoBehaviour
{

    public AudioSource jogar;

    public AudioClip Click;

    public static Som sfxInstance;

    private void Awake()
    {
       if (sfxInstance != null && sfxInstance != this) 
        {
            Destroy(this.gameObject);
            return;
        }
       sfxInstance = this;
        DontDestroyOnLoad(this);
     
    }
   
}
