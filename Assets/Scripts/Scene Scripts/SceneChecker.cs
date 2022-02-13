using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneChecker : MonoBehaviour
{
    public string SceneName;
    private PlayerMovement player;

    public float posX;
    public float posY;
    public float dirX;
    public float dirY;
 
    private void Awake()
    {
        PlayerPosition();
    }

    void PlayerPosition()
    {
        player = GameObject.Find("Character").GetComponent<PlayerMovement>();
        player.transform.position = new Vector3(posX, posY, 0);
        player.SetLastMoveDir(dirX, dirY);
        player.SetLastScene(SceneName);
    }
}
