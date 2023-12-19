using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class button : MonoBehaviour, IInteractable
{
    [SerializeField] private GameObject doorhinge;
    [SerializeField] private GameObject buttonpress;

    [SerializeField] private string Prompt;

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
            doorhinge.transform.rotation = Quaternion.Euler(0, 90, 0);
            buttonpress.transform.localScale = new Vector3(0.2f,0.15f,0.4f);
            timer = 1f;
            isinteractable= false;
        }
        
        return true;
    }

    
}
