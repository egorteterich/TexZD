using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ControlSceneAndMenu : MonoBehaviour
{

    public GameObject buttonsMenu;
    public GameObject buttonsExit;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ShowExitButtons()
    {
        buttonsMenu.SetActive(false);
        buttonsExit.SetActive(true);
    }

    public void BackInMenu()
    {
        buttonsMenu.SetActive(true);
        buttonsExit.SetActive(false);
    }

    public void ExitGame()
    {
        Application.Quit();
    }

    public void NewGameLoadScene()
    {
        SceneManager.LoadScene(0);
    }

    public void NewGameLoadScene1()
    {
        SceneManager.LoadScene(1);
    }

    public void NewGameLoadScene2()
    {
        SceneManager.LoadScene(2);
    }

    public void NewGameLoadScene3()
    {
        SceneManager.LoadScene(3);
    }

}
