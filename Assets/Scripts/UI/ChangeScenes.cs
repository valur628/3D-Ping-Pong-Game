using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class ChangeScenes : MonoBehaviour
{
    public string LVset;
    void Start()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(LVset);
    }
}

//        Application.LoadLevel(LVset); 쓰지말것 옜날거임
