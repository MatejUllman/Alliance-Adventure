using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{
    [SerializeField]
    private GameObject doorCollider;
    [SerializeField]
    private GameObject keyCollider;
    void Start()
    {
        doorCollider.GetComponentInChildren<BoxCollider>().enabled = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        doorCollider.GetComponentInChildren<BoxCollider>().enabled = true;

        Destroy(keyCollider);
        
    }
}
