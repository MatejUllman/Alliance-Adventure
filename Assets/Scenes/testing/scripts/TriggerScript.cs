using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerScript : MonoBehaviour
{
    public GameObject textObject;

   

    private void Start()
    {
        // Skrytí textu na zaèátku
        if (textObject != null)
        {
            textObject.SetActive(false);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            textObject.SetActive(true);
            StartCoroutine(HideTextAfterDelay(10));
        }
    }

    private IEnumerator HideTextAfterDelay(float delay)
    {
        yield return new WaitForSeconds(delay);
        textObject.SetActive(false);
    }
}
