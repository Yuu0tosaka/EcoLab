using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivingCircle : MonoBehaviour
{
    public GameObject[] childUpgrade;
    
    void Start()
    {
        // childUpgrade.SetActive(false);
    }

    
    public void Click()
    {
        foreach(GameObject child in GameObject.FindGameObjectsWithTag("childUp"))
        {
            bool is_in = false;
            foreach (GameObject own_child in childUpgrade)
            {
                is_in = is_in || (child == own_child);
            }
            if(!is_in){
                child.GetComponent<Animator>().SetBool("isAppeared", true);
                StartCoroutine(deactiveAfter(child, .65f, true));
            }
        }
        foreach (GameObject child in childUpgrade)
        {
            child.SetActive(true);
            child.GetComponent<Animator>().SetBool("isAppeared", false);
        }        
    }

    public static IEnumerator deactiveAfter(GameObject obj, float secs, bool save)
     {
        yield return new WaitForSeconds(secs);
        if(save){
            obj.SetActive(false);
        } else {
            Destroy(obj);
        }
     }
}
