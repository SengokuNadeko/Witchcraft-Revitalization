using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnterBuilding : MonoBehaviour
{
    public void EnterRoom()
    {
        SceneManager.LoadScene("Room1");
    }
}
