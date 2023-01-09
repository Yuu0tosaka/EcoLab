using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AreaManagerController : MonoBehaviour
{
    public void LoadWorkSpace( string input )
    {
        Carrier.areaName = input;
        SceneManager.LoadScene("WorkSpace");
    }
}
