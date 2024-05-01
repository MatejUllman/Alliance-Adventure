using Cinemachine;
using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

[RequireComponent(typeof(Camera))] 

public class Cameramovement : MonoBehaviour
{
    //list of players
    [SerializeField] private List<Transform> targets;

    //offset from centre
    [SerializeField] private Vector3 offset;

    //setings of FOV
    [SerializeField] private float minFOV = 40f;
    [SerializeField] private float maxFOV = 15f;


    //velocity of camera
    private Vector3 velocity;

    //for smooting of camera movement 
    public float smoothTime = .5f;

    //cam
    private Camera cam;
    void Start()
    {
        cam = GetComponent<Camera>();
    }




    //zooming if players are close and oposite
    void zoom()
    {
        float newZoom = Mathf.Lerp(maxFOV, minFOV, GetGratestDistance() / 50f);
        cam.fieldOfView = Mathf.Lerp(cam.fieldOfView, newZoom, Time.deltaTime);

    }


    void LateUpdate()
    {
        if (targets.Count == 0)
            return;
        move();
        zoom();
    }
    //movement of camera
    void move()
    {
        Vector3 centre = GetCentre();
        Vector3 newPosition = centre + offset;
        transform.position = Vector3.SmoothDamp(transform.position, newPosition, ref velocity, smoothTime);
    }




    //gets centre of players
    Vector3 GetCentre()
    { 
       if(targets.Count == 0)
        {
            return targets[0].position;
        }
       var bounds = new Bounds(targets[0].position, Vector3.zero);
        for(int i = 0; i < targets.Count;i++) {

            bounds.Encapsulate(targets[i].position);
        }
        return bounds.center;
    }




    //it is getting the gratest distance between players
    float GetGratestDistance()
    {
        var bounds = new Bounds(targets[0].position, Vector3.zero);
        for (int i = 0; i < targets.Count; i++)
        {

            bounds.Encapsulate(targets[i].position);
        }
        return bounds.size.x;
    }
}
