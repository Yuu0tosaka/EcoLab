using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class SpawnerManager : MonoBehaviour
{
    // Start is called before the first frame update
    public static float total_clearness;
    public static int FramesToSpawn = 400;
    public GameObject coin;
    public Text percents;
    public GameObject winningPop;
    int counter = 0;
    System.Random rand = new System.Random();
    void Start()
    {
        Application.targetFrameRate = 60;
    }

    // Update is called once per frame
    void Update()
    {
        float a = 0f;
        foreach(GameObject bar in GameObject.FindGameObjectsWithTag("Slider"))
        {
            a += bar.GetComponent<Slider>().value;
        }
        total_clearness = a;
        if (total_clearness == 1){
            winningPop.SetActive(true);
        }
        percents.text = Math.Round(total_clearness*100, 2).ToString()+"%";
        if(counter>(.7f*FramesToSpawn/(total_clearness+.7f))){
            counter = 0;
            float x = (float)rand.NextDouble();
            float y = (float)rand.NextDouble();
            float l = this.GetComponent<RectTransform>().anchorMin.x;
            float d = this.GetComponent<RectTransform>().anchorMin.y;
            float w = this.GetComponent<RectTransform>().anchorMax.x - l;
            float h = this.GetComponent<RectTransform>().anchorMax.y - d;
            GameObject newcoin = Instantiate(coin, new Vector2(0, 0), Quaternion.identity, transform);
            float cx = x*w;
            float cy = y*h;
            newcoin.GetComponent<RectTransform>().anchorMin = new Vector2(cx-w*.08f, cy-h*.16f);
            newcoin.GetComponent<RectTransform>().anchorMax = new Vector2(cx+w*.08f, cy+h*.16f);
            newcoin.GetComponent<RectTransform>().offsetMax = new Vector2(0, 0);
            newcoin.GetComponent<RectTransform>().offsetMin = new Vector2(0, 0);
            newcoin.transform.SetParent(transform);
        }
        counter++;
    }
}
