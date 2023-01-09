using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ProgressBar : MonoBehaviour
{
    // 40700 = 100%
    public float maximum;
    public float current;
    public float minimum;
    public float coef = 0.0001f;
    public static GameObject fill;
    private Slider slider;
    public string region_name;
    int amount;
    public static float add;
    void Awake()
    {
        Application.targetFrameRate = 60;
        slider = GetComponent<Slider>();
        current = slider.value;
    }

    public static IEnumerator Decreace(float by, int secs){
        add = by/(60*secs);
        // fill.GetComponent<Image>().color = Color.red;
        yield return new WaitForSeconds(secs);
        add = 0f;
        // fill.GetComponent<Image>().color = Color.green;
    }
    
    void Update()
    {
        amount = int.Parse(MoneyBehaviour.get_reg_vols(region_name));
        current += coef * amount / maximum + add;
        slider.value = current;
    }
}
