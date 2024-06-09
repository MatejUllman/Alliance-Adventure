using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Settings : MonoBehaviour
{
    public void setGraphics(int GraphicsIndex)
    {
       QualitySettings.SetQualityLevel(GraphicsIndex);
    } 
    public void SetFullScreen(bool FullScreen)
    {
   
        Screen.fullScreen = FullScreen; 
    }
}
