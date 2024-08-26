using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class sceneManager : MonoBehaviour
{
    public Button[] buttons;
    private void awake()
    {
        int unlockedLevel = PlayerPrefs.GetInt("UnlockedLevel", 1);
        for (int i = 0; i < buttons.Length; i++) {
            buttons[i].interactable = false;
        }
        for (int i = 0;i < unlockedLevel; i++)
        {
            buttons[i].interactable = true;
        }
    }
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
