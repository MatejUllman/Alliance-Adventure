using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pleaszrePlateBDoorTwo : MonoBehaviour
{
    [SerializeField] Animator myDoor = null;

    [SerializeField] GameObject platepress;
    private float timer;
    //bool IsOpened = false;











    private void Update()
    {
        if (timer > 0)
        {
            timer -= Time.deltaTime;
            //Debug.Log("ubíhá èas");
            if (timer <= 0f)
            {
                //Debug.Log("èas dobìhl");
                //doorhinge.transform.rotation = Quaternion.Euler(0, 0, 0);
                myDoor.Play("closeBDooor2", 0, 0.0f);
                platepress.transform.localScale = new Vector3(1.2f, 0.1f, 1.2f);
            }
        }
    }
    private void OnTriggerEnter(Collider other)
    {

        platepress.transform.localScale = new Vector3(0.6f, 0.05f, 0.6f);
        myDoor.Play("openBDoor2", 0, 0.0f);
        //doorhinge.transform.rotation = Quaternion.Euler(0, 90, 0);


    }
    private void OnTriggerStay(Collider other)
    {

        //doorhinge.transform.rotation = Quaternion.Euler(0, 90, 0);
        //myDoor.Play("closeSDoor", 0, 0.0f);

        timer = 1f;



    }
}
