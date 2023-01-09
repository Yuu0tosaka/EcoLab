using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CopyingCircle : MonoBehaviour
{
    
    public Text infoo;
    public RectTransform rt;
    public Transform newParent;
    public GameObject canva;
    public GameObject bg;
    public GameObject button;
    public string infoInput;
    void Start()
    {
        rt = GetComponent<RectTransform>();
        canva = GameObject.Find("CanvasLevel");
        bg = canva.transform.Find("Background").gameObject;
        newParent = bg.transform.Find("RightPanel");
    }


    public void CopyMe()
    {
        GameObject originalGameObject = GameObject.Find("RightPanel");
        GameObject child = originalGameObject.transform.GetChild(0).gameObject;
        Destroy(child);

        GameObject prefab_gameObject = Instantiate(
            gameObject,
            transform.position,
            Quaternion.identity,
            transform
        );
        prefab_gameObject.tag = "Untagged";
        prefab_gameObject.name = "Prefab GameObject";
        prefab_gameObject.transform.SetParent(newParent);
        prefab_gameObject.GetComponent<RectTransform>().localPosition = new Vector3(-194.169052f ,105.174393f ,-3163.85815f);
        prefab_gameObject.GetComponent<RectTransform>().anchorMax = new Vector2(0.1743034f, 0.8890001f);
        prefab_gameObject.GetComponent<RectTransform>().anchorMin = new Vector2(0.07620224f, 0.739f);
        prefab_gameObject.GetComponent<RectTransform>().offsetMax = new Vector2(0, 0);
        prefab_gameObject.GetComponent<RectTransform>().offsetMin = new Vector2(0, 0);
        prefab_gameObject.GetComponent<Button>().interactable =  false;
        prefab_gameObject.GetComponent<Animator>().enabled = false;

        infoo.text = infoInput;
        foreach(GameObject upbutton in GameObject.FindGameObjectsWithTag("upgradeButton"))
        {
            upbutton.SetActive(false);
        }
        button.SetActive(true);
        if(button.transform.childCount!=0)button.transform.GetChild(1).GetComponent<Text>().text = button.GetComponent<ChangingCurrecny>().getReq();
    }
    
}
