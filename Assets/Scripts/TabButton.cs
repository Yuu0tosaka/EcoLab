using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using TMPro;
using System;

[RequireComponent(typeof(Image))]
public class TabButton : MonoBehaviour, IPointerEnterHandler, IPointerClickHandler, IPointerExitHandler
{
    public TabGroup tabGroup;
    public TMP_Text tmpText;
    public string areaTitle;
    public Image background;
    public GameObject ContainerShow;
    public GameObject barShow;
    void Start()
    {
        background = GetComponent<Image>();
        tabGroup.Subscribe(this);
        barShow.transform.position = new Vector2(barShow.transform.position.x+10000, barShow.transform.position.y);
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        tabGroup.OnTabSelected(this);
        if(tmpText.text == areaTitle){
            return;
        }
        tmpText.text = areaTitle;
        MoneyBehaviour.currentRegPeople = areaTitle;
        foreach (GameObject slider in GameObject.FindGameObjectsWithTag("Slider"))
        {
            slider.transform.position = new Vector2(barShow.transform.position.x, barShow.transform.position.y);
        }
        barShow.transform.position = new Vector2(barShow.transform.position.x-10000, barShow.transform.position.y);
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        tabGroup.OnTabEnter(this);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        tabGroup.OnTabExit(this);
    }

    void Update()
    {
        
    }
}
