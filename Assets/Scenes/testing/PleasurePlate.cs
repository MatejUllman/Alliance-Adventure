using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PleasurePlate : MonoBehaviour
{
    [SerializeField] GameObject doorhinge;

    [SerializeField] GameObject platepress;
    private float timer;
    bool IsOpened = false;











    private void Update()
    {
        if (timer > 0)
        {
            timer -= Time.deltaTime;
            //Debug.Log("ub�h� �as");
            if(timer <= 0f)
            {
                //Debug.Log("�as dob�hl");
                doorhinge.transform.rotation = Quaternion.Euler(0, 0, 0);
                platepress.transform.localScale = new Vector3(1.2f,0.1f,1.2f);  
            }
        }
    }
   private void OnTriggerEnter(Collider other)
    {

        platepress.transform.localScale= new Vector3(0.6f,0.05f,0.6f);
        doorhinge.transform.rotation = Quaternion.Euler(0, 90, 0);


    }
    private void OnTriggerStay(Collider other)
    {
       
            doorhinge.transform.rotation = Quaternion.Euler(0, 90, 0);

            timer = 1f;

          

    }
}
