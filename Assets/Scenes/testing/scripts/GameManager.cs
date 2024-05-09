using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private static GameManager instance;

    public static GameManager Instance { get => instance; set => instance = value; }

    public void Awake()
    {
        if(Instance == null)
        {
            Instance = this;
        }

    }
    public bool power;
    public void SwitchPower(bool value) => power = value;
    
}
