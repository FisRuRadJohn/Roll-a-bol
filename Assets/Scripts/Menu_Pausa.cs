using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Menu_Pausa : MonoBehaviour


    
{
    public GameObject pausePanel;

    bool isPaused = false; //las bool son para variables de true o false
                           // empieza en false para que no este pausado al iniciar el juego
                        


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isPaused)
            {
                MenuContinue(); //siempre que llamamos a una función void  ponemos los parentesis 
            }
            else
            {
                MenuPause(); //llama a lo de abajo 
            }

            //pausePanel.SetActive(true); //activar el panel de pausa al pulsar escape
            //Time.timeScale = 0; //para que se pare el tiempo dentro del juego al aparecer la ventana de pausa
            //isPaused = true;
           
        }
    }

    public void MenuPause()     //este tipo de cosas se usan como algo asi como un prefav y llamarlo en el if y else del codigo de arriba
    {
        pausePanel.SetActive(true);
        Time.timeScale = 0;
        isPaused = true;
    }

    public void MenuContinue()
    {
        pausePanel.SetActive(false);
        Time.timeScale = 1;
        isPaused = false;
    }

    public void ExitGame()
    {
        Application.Quit();
    }

    public void GameReset()
    {
        SceneManager.LoadScene("SampleScene");
        Time.timeScale = 1;
    }
}
