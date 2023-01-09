using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TotalTotalManager : MonoBehaviour
{

    private int TTvols;
    private int TTpoints;
    public Text TTTvols;
    public Text TTTpoints;
    // Start is called before the first frame update
    void Start()
    {
        TTvols = 0;
        TTpoints = 0;
        foreach(GameObject total in GameObject.FindGameObjectsWithTag("moneyBeh"))
        {
            TTvols += total.GetComponent<TotalResources>()._Total_Vols;
            TTpoints += total.GetComponent<TotalResources>()._Total_Cash;
        }
        TTTpoints.text = TTpoints.ToString();
        TTTvols.text = TTvols.ToString();
    }

    // Update is called once per frame
    void Update()
    {
    }
}
