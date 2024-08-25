using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UiManager : MonoBehaviour
{
    public GameObject optionsPanel;
    public void OptionPanel(){
        Time.timeScale = 0;
        optionsPanel.SetActive(true);
    }
    public void Return(){
        Time.timeScale = 1;
        optionsPanel.SetActive(false);
    }
    public void AnotherOptions(){

    }
    public void GoMainMenu(){
        SceneManager.LoadScene("Lvl1");
    }
    public void QuitGame(){
        Application.Quit();
    }
}
