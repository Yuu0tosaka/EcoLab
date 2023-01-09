using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartToMain : MonoBehaviour
{
    // Start is called before the first frame update
    public void ChangeSceneStartToMain()
    {
        SceneManager.LoadScene("Main");
    }

    public void StartToTutorial()
    {
        SceneManager.LoadScene("Tutorial");
    }

    public void ToStart()
    {
        SceneManager.LoadScene("StartMenu");
    }
}
