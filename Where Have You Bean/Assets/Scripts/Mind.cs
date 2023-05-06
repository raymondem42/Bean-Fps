using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mind : MonoBehaviour
{
    public GameObject[] PlayerView;
    public GameObject[] Players;
    public GameObject[] Grapplers;

    [SerializeField]
    GameObject currentPlayer;
    [SerializeField]
    GameObject currentViewing;
    [SerializeField]
    GameObject currentGrappler;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 1; i < Players.Length; i++)
        {
            Players[i].GetComponent<PlayerMovement>().enabled = false;
        }

        for (int e = 1; e < PlayerView.Length; e++)
        {
            PlayerView[e].GetComponent<MoveCamera>().enabled = false;
        }

        for (int b = 1; b < Grapplers.Length; b++)
        {
            Grapplers[b].GetComponent<GrapplingGun>().enabled = false;
        }




        currentPlayer = Players[0];
        currentViewing = PlayerView[0];
        currentGrappler = Grapplers[0];

    }

    public void ChangePlayer(GameObject player)
    {
        currentPlayer.GetComponent<PlayerMovement>().enabled = false;
        currentPlayer = player;
    }
    public void ChangeView(GameObject viewing)
    {
        currentViewing.GetComponent<MoveCamera>().enabled = false;
        currentViewing = viewing;
    }

    public void ChangeGrappler(GameObject Grapple)
    {
        currentGrappler.GetComponent<GrapplingGun>().enabled = false;
        currentGrappler = Grapple;
    }


}
