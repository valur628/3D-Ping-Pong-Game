using UnityEngine;
using System.Collections;

public class GamePaused : MonoBehaviour
{
    public GameObject Pauselogo;
    public GameObject Resumed;
    public GameObject MainMenu;
    public GameObject GameExit;
    public GameObject player_1;
    public GameObject player_2;
    public GameObject GameResume;
    public GameObject GameRestart;
    public bool paused;
    void Start()
    {
        paused = false;
        Pauselogo.SetActive(false);
        Resumed.SetActive(false);
        MainMenu.SetActive(false);
        GameExit.SetActive(false);
        GameRestart.SetActive(false);
    }

    void Update()
    {
        if (Input.GetKeyDown("escape"))
        {
            paused = !paused;
            if (paused && Time.timeScale == 1.0F)
            {
                Time.timeScale = 0;
                Pauselogo.SetActive(true);
                Resumed.SetActive(true);
                MainMenu.SetActive(true);
                GameExit.SetActive(true);
                GameRestart.SetActive(true);
                player_1.GetComponent<Player_1Move>().enabled = false;
                player_2.GetComponent<Player_2Move>().enabled = false;
            }
            else if (!paused && Time.timeScale == 0.0F)
            {
                Time.timeScale = 1;
                Pauselogo.SetActive(false);
                Resumed.SetActive(false);
                MainMenu.SetActive(false);
                GameExit.SetActive(false);
                GameRestart.SetActive(false);
                player_1.GetComponent<Player_1Move>().enabled = true;
                player_2.GetComponent<Player_2Move>().enabled = true;
            }
        }
    }
    public void gameResume()
    {
        Time.timeScale = 1;
        Pauselogo.SetActive(false);
        Resumed.SetActive(false);
        MainMenu.SetActive(false);
        GameExit.SetActive(false);
        GameRestart.SetActive(false);
        player_1.GetComponent<Player_1Move>().enabled = true;
        player_2.GetComponent<Player_2Move>().enabled = true;
    }
}

/* void Update()
    {
        if (Input.GetKey("escape"))
            Application.Quit();
    }
    */
