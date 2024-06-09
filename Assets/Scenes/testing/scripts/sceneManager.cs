using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneManager : MonoBehaviour
{
   public void Menu()
    {
        SceneManager.LoadScene("Menu");
    }
    public void Settings()
    {
        SceneManager.LoadScene("Settings");
    }
    public void Levels()
    {
        SceneManager.LoadScene("LevelSlector");

    }
    public void Tutorial()
    {
        SceneManager.LoadScene("tutorial");
    }
    public void Castle()
    {
        SceneManager.LoadScene("castle");
    }
    public void Factory()
    {
        SceneManager.LoadScene("factory");
    }
    public void Office()
    {
        SceneManager.LoadScene("Office");
    }
    public void Quit()
    {
        Application.Quit();
    }

}
