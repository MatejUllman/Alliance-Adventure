using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class conveyor_belt : MonoBehaviour
{
    public float speed = 100f;
    public List<GameObject> gameObjects;
    public Vector3 direction;
    

   

    private void Update()
    {
        for(int i = 0; i <= gameObjects.Count -1; i++)
        {
            gameObjects[i].GetComponent<Rigidbody>().velocity = speed * direction * Time.deltaTime;
            
        }
        
        
       
    }
    private void OnTriggerEnter(Collider other)
    {
        gameObjects.Add(other.gameObject);
    }
    private void OnTriggerExit(Collider other)
    {
        gameObjects.Remove(other.gameObject);

    }

}
