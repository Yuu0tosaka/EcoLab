using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PopBehaviour : MonoBehaviour
{
    Animator animator;
    int cool = 0; 

    void Start()
    {
        animator = gameObject.GetComponent<Animator>();
        Application.targetFrameRate = 60;
    }

    
    void Update()
    {
        if(cool < 120)cool++;
        else if (Input.anyKeyDown)
        {
            animator.SetTrigger("hide");
        }
        else if (Input.touchCount > 0)
        {
            animator.SetTrigger("hide");
        }
    }
}
