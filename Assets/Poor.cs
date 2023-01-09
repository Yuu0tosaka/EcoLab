using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Poor : MonoBehaviour
{
    // Start is called before the first frame update
    void Awake(){
        if(gameObject.GetComponent<CopyingCircle>().button.transform.childCount>0){
            var colors = gameObject.GetComponent<Button>().colors;
            colors.normalColor = Color.black;
            gameObject.GetComponent<Button>().colors = colors;
        }
    } 
    void Update()
    {
        if(gameObject.GetComponent<CopyingCircle>().button.transform.childCount>0){
            if(gameObject.GetComponent<CopyingCircle>().button.GetComponent<ChangingCurrecny>().able()){
                var colors = gameObject.GetComponent<Button>().colors;
                colors.normalColor = Color.white;
                gameObject.GetComponent<Button>().colors = colors;
            }else{
                var colors = gameObject.GetComponent<Button>().colors;
                colors.normalColor = Color.black;
                gameObject.GetComponent<Button>().colors = colors;
            }
        }
    }
}
