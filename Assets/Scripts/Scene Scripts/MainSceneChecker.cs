using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainSceneChecker : MonoBehaviour
{
    private PlayerMovement player;

    // Start is called before the first frame update
    private void Awake()
    {
        PositionCheck();
    }


    void PositionCheck()
    {
        player = GameObject.Find("Character").GetComponent<PlayerMovement>();

        if (player.GetLastScene() == "Room1")
        {
            player.SetPlayerPos(-3.5f, -0.5f);
        }
    }
}
