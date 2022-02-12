using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LeaveBuilding : MonoBehaviour
{
    public void LeaveRoom()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
