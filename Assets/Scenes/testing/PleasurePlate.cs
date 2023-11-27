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
            //pøiøadit animaci otevírání ---> set timer ---> zavøeno
            Debug.Log("otevøeno");
            IsOpened = true;
        }
        
        
    }
}
