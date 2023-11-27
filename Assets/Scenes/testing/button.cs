using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class button : MonoBehaviour, IInteractable
{
    [SerializeField] private string Prompt;
    public string InteractionPrompt => Prompt;
    public bool Interact(Interactor interactor)
    {
        Debug.Log("zm·Ëknou");
        return true;
    }

    
}
