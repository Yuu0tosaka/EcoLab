using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangingCurrecny : MonoBehaviour
{
    private Button buttonInter;

    int ecoPoints;
    int volanPoints;
    public int reqPeople;
    public int plusEco;
    public int plusPeople;
    public int plusClearness;
    public float plusTimeToEvent;
    void Start()
    {
        buttonInter = GetComponent<Button>();
    }
    void Update(){
        if(MoneyBehaviour.total_vols<reqPeople||int.Parse(MoneyBehaviour.Cash)<plusEco){
            buttonInter.interactable = false;
        }else{
            buttonInter.interactable = true;
        }
    }
    public void Purchase()
    {
        GameObject.FindGameObjectsWithTag("Slider")[0].GetComponent<Slider>().value+=plusClearness/100;
        ecoPoints = int.Parse(MoneyBehaviour.Cash);
        ecoPoints = ecoPoints - plusEco;
        MoneyBehaviour.Cash = ecoPoints.ToString();

        volanPoints = int.Parse(MoneyBehaviour.get_vols());
        volanPoints = volanPoints + plusPeople;
        MoneyBehaviour.set_vols(volanPoints.ToString());
        reqPeople = 1000000;
        buttonInter.interactable = false;
    }
    public string getReq(){
        if(reqPeople != 1000000)
        return plusEco.ToString()+" Эко очков, "+reqPeople.ToString()+" волонтёров требуется";
        return "";
    }
    public bool able(){
        return MoneyBehaviour.total_vols>=reqPeople&&int.Parse(MoneyBehaviour.Cash)>=plusEco;
    }
}
