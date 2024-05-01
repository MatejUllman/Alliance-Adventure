using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Interactor : MonoBehaviour
{
    
    [SerializeField]  Transform InteractionPoint;
    [SerializeField]  float InteractionPointRadius = 0.5f;
    [SerializeField]  LayerMask InteracteableMask;

    private readonly Collider[] colliders = new Collider[3];
    [SerializeField] int numFound;
   

    private void Update()
    {
        numFound = Physics.OverlapSphereNonAlloc(InteractionPoint.position, InteractionPointRadius, colliders, InteracteableMask);

        if(numFound > 0)
        {
            var interactable = colliders[0].GetComponent<IInteractable>();
            if(interactable != null && Input.GetKeyDown(KeyCode.E))
            {
                interactable.Interact(this);
            }
        }
    }
    private void OnDrawGizmos()
    {
       Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(InteractionPoint.position, InteractionPointRadius);
    }
}
