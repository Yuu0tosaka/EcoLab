using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class EventPopManager : MonoBehaviour
{
    public int min_time;
    public int first_pop_time;
    public int random_time_max;
    public Text EventPlotUI;
    public GameObject popup;
    int curtime;
    System.Random rand = new System.Random();
    int time_counter=0;
    int to_next;
    public string[] EventTexts;
    public Vector3[] EventNumbers;

    void Start()
    {
        Application.targetFrameRate = 60;
        to_next = first_pop_time+rand.Next(0, random_time_max);
    }

    void Update()
    {
        time_counter++;
        if(time_counter>to_next){
            to_next = min_time+rand.Next(0, random_time_max);
            time_counter = 0;
            int i = rand.Next(0, EventTexts.Length);
            EventPlotUI.text = EventTexts[i];
            Vector3 v = EventNumbers[i];
            int vol = (int)v.x;
            float clearness = v.y;
            float money_freq = v.z;
            foreach(string reg in MoneyBehaviour.all_regions){
                MoneyBehaviour.regions[reg] = (int.Parse(MoneyBehaviour.regions[reg])+vol).ToString();
            }
            SpawnerManager.FramesToSpawn = (int)(SpawnerManager.FramesToSpawn*money_freq);
            StartCoroutine(ProgressBar.Decreace(clearness, 60));
            popup.SetActive(true);
        }
    }
}
