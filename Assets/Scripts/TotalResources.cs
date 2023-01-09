using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TotalResources : MonoBehaviour
{
    public int _Total_Vols;
    public int _Total_Cash;
    void Start(){
        DontDestroyOnLoad(gameObject);
    }
}
