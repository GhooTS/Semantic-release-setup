using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaceHolder : MonoBehaviour
{
    private Collider coll;
    [HideInInspector] public string playerName;
    private BoardController boardController;
    private bool interactable;

    void Start()
    {
        coll = GetComponent<Collider>();
        boardController = FindObjectOfType<BoardController>();
        interactable = true;
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (coll.Raycast(ray, out hit, 100.0F) && interactable)
            {
                interactable = false;
                playerName = boardController.SetPlayerName();
                boardController.PlaceObject(transform.position);
                
            }
        }

    }
}