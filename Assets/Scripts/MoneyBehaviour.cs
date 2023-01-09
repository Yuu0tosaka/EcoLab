using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoneyBehaviour : MonoBehaviour
{
    [SerializeField]
    // public static MoneyBehaviour instance;
    public static string Cash;
    public static int total_vols;
    public Text budget;
    int counter=0;
    public Text volanteersAmount;
    public static string currentRegPeople = "Джумгальский Район";
    public static string[] all_regions = {"Нарынский Район","Ат-Башинский Район","Кочкорский Район","Ак-Талинский Район","Джумгальский Район"};
    public static Dictionary<string, string> regions = new Dictionary<string, string>();
    void Awake(){
        Application.targetFrameRate = 60;
        regions = new Dictionary<string, string>();
        regions.Add("Нарынский Район", "0");
        regions.Add("Ат-Башинский Район", "0");
        regions.Add("Кочкорский Район", "0");
        regions.Add("Ак-Талинский Район", "0");
        regions.Add("Джумгальский Район", "1");
        Cash = "0";
    }
    void Start(){
        regions = new Dictionary<string, string>();
        regions.Add("Нарынский Район", "0");
        regions.Add("Ат-Башинский Район", "0");
        regions.Add("Кочкорский Район", "0");
        regions.Add("Ак-Талинский Район", "0");
        regions.Add("Джумгальский Район", "1");
        Cash = "0";
    }
    void Update()
    {
        GameObject.FindGameObjectsWithTag("moneyBeh")[0].GetComponent<TotalResources>()._Total_Cash = int.Parse(Cash);
        GameObject.FindGameObjectsWithTag("moneyBeh")[0].GetComponent<TotalResources>()._Total_Vols = total_vols;
        total_vols = 0;
        foreach(string vol in all_regions){
            try{
                int add = int.Parse(regions[vol]);
                total_vols += add;
                if (counter<180){
                    counter++;
                }else if(add>100){
                    regions[vol] = (add+1).ToString();
                    counter = 0;
                }
            }catch{}
        }

        budget.text = string.Format("{0} очков", Cash);
        try{
            volanteersAmount.text = string.Format("{0} волонтеров", regions[currentRegPeople]);
        }catch{
            volanteersAmount.text = "0 волонтеров";
        }
        
    }
    public static string get_vols(){
        try{
            return regions[currentRegPeople];
        }catch{
            return "0";
        }
    }
    public static string get_reg_vols(string reg){
        try{
            return regions[reg];
        }catch{
            return "0";
        }
    }
    public static void set_vols(string setter){
        try{
            regions[currentRegPeople] = setter;
        }catch{}
    }
}
