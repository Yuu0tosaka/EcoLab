using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AreaImageManager : MonoBehaviour
{
    public Image example;
    public Sprite[] source = new Sprite[7];
    void Start()
    {
        example = GetComponent<Image>();
        for (int i = 0; i < source.Length; i++)
        {
            if (SystemController.forImage == source[i].name)
            {
                 example.sprite = source[i];
            }
        }

        
        
    }


}
