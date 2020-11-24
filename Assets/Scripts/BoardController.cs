using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoardController : MonoBehaviour
{
    public GameController gameController;
    private int id = 0;
    public List<PlaceHolder> placeHolders;
    
   
    void Start()
    {
        gameController = FindObjectOfType<GameController>();

    }

    public void PlaceObject(Vector3 objectPosition)
    {
        Instantiate(gameController.actualPlayer, objectPosition, Quaternion.identity);
        if (CheckIfWin())
        {
            Debug.Log("Win " + gameController.actualPlayer.name);
            gameController.RestartGame();
        }
        gameController.SwitchPlayer();
        
    }
    bool CheckIfWin()
    {
        string playerName = gameController.actualPlayer.name;
        if (placeHolders[0].playerName == playerName && placeHolders[1].playerName == playerName && placeHolders[2].playerName == playerName)
        {
            return true;
        }
        else if (placeHolders[3].playerName == playerName && placeHolders[4].playerName == playerName && placeHolders[5].playerName == playerName)
        {
            return true;
        }
        else if (placeHolders[6].playerName == playerName && placeHolders[7].playerName == playerName && placeHolders[8].playerName == playerName)
        {
            return true;
        }
        else if (placeHolders[0].playerName == playerName && placeHolders[3].playerName == playerName && placeHolders[6].playerName == playerName)
        {
            return true;
        }
        else if (placeHolders[1].playerName == playerName && placeHolders[4].playerName == playerName && placeHolders[7].playerName == playerName)
        {
            return true;
        }
        else if (placeHolders[2].playerName == playerName && placeHolders[5].playerName == playerName && placeHolders[8].playerName == playerName)
        {
            return true;
        }
        else if (placeHolders[0].playerName == playerName && placeHolders[4].playerName == playerName && placeHolders[8].playerName == playerName)
        {
            return true;
        }
        else if (placeHolders[2].playerName == playerName && placeHolders[4].playerName == playerName && placeHolders[6].playerName == playerName)
        {
            return true;
        }

        return false;
    }
    public string SetPlayerName()
    {
        return gameController.actualPlayer.name;
    }
}
