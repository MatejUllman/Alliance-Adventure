using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PleasurePlate : MonoBehaviour
{
    [SerializeField] GameObject door;
    bool IsOpened = false; 
    private void OnTriggerEnter(Collider other)
    {
        if (!IsOpened)
        {
            //p�i�adit animaci otev�r�n� ---> set timer ---> zav�eno
            Debug.Log("otev�eno");
            IsOpened = true;
        }
        
        
    }
}
