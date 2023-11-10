using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MainMenu : MonoBehaviour
{

    public GameObject PauseMenu;
    public GameObject OptionsMenu;
    public GameObject MainMenu2;

    public void PlayGame() 
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        Time.timeScale = 1;
    
    }

    public void MainMenuMenu()
    {
        SceneManager.LoadSceneAsync("Menu", LoadSceneMode.Single);
        
    }

    public void Options()
    {
        OptionsMenu.SetActive(true);
        MainMenu2.SetActive(false);
    }

    public void back()
    {
        OptionsMenu.SetActive(false);
        MainMenu2.SetActive(true);
    }


    public void Pause() 
    {
        PauseMenu.SetActive(true);
        Time.timeScale = 0;
      
    }

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
            Pause();
    }

    public void Continue()
    {
        PauseMenu.SetActive(false);
        Time.timeScale = 1;
    }

    public void QuitGame ()
    {
        Debug.Log("Quit!");
        Application.Quit();


    }




}
