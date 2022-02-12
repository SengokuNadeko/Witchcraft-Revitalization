using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Enter_Building_1 : MonoBehaviour
{
    public void EnterRoom()
    {
        SceneManager.LoadScene("Room1");
    }
}
