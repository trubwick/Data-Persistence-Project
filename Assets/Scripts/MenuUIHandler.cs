using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuUIHandler : MonoBehaviour
{
   
    public string playerName;

    public void PressPlay()
    {
        Debug.Log(playerName);
        SceneManager.LoadScene(1);
    }

    public void GetPlayerName(string text)
    {
        playerName = text;
    }
}
