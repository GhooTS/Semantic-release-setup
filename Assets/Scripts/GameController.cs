using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class GameController : MonoBehaviour {

    public GameObject player_1;
    public GameObject player_2;
    [HideInInspector] public GameObject actualPlayer;

    void Start()
    {
        actualPlayer = player_1;
    }

    public void SwitchPlayer()
    {
        if(actualPlayer == player_1)
        {
            actualPlayer = player_2;
        }
        else
        {
            actualPlayer = player_1;
        }
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}
