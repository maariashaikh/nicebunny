using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour


{

    public GameObject TYM, CYC, Instructions, Menu, Pause, Scoreboard;

    // Start is called before the first frame update
    void Start()
    {
        Menu.SetActive(true);
    }

    public void SwitchPanel(GameObject Main){

        Menu.SetActive(false);
        TYM.SetActive(false);
        CYC.SetActive(false);
        Scoreboard.SetActive(false);
        Instructions.SetActive(false);
        Main.SetActive(true);
        Pause.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartGame()
    
    {
         
    }



    public void QuitGame(){

        Application.Quit();
        Debug.Log("QuitGame");

    }
}
