using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class buttonSDoor:MonoBehaviour, IInteractable
{
    [SerializeField] private Animator myDoor = null;
    [SerializeField] private GameObject buttonpress;

    [SerializeField] private string Prompt;
    [SerializeField] private bool isOpened = false;

    private float timer;
    private bool isinteractable = true;
    public string InteractionPrompt => Prompt;


    private void Update()
    {
       
        if(!isinteractable)
        {
            timer -= Time.deltaTime;
            if (timer <= 0f)
            {
                buttonpress.transform.localScale = new Vector3(0.4f, 0.15f, 0.8f);
                isinteractable = true;
            }
        }
    }
    public bool Interact(Interactor interactor)
    {
        if (isinteractable)
        {
            if (!isOpened)
            {
                myDoor.Play("openSDoor", 0, 0.0f);
                buttonpress.transform.localScale = new Vector3(0.2f, 0.15f, 0.4f);
                timer = 1f;
                isinteractable = false;
                isOpened= true;
            }
            else if(isOpened)
            {
                myDoor.Play("closeSDooor", 0, 0.0f);
                buttonpress.transform.localScale = new Vector3(0.2f, 0.15f, 0.4f);
                isOpened = false;
                isinteractable = false;
                timer = 1f;
            }
        }
        
        return true;
    }

    
}
