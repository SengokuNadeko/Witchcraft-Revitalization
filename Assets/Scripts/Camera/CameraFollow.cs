using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform player;
    public GameObject playerObject;
    public Vector3 camOffset;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(player.position.x + camOffset.x, player.position.y + camOffset.y, player.position.z + camOffset.z);
    }
}
