using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SystemController : MonoBehaviour
{
    public Text areaText;    
    public static string forImage;
    void Start()
    {
        areaText.text = Carrier.areaName;
        forImage = areaText.text;
    }

    

    
}
