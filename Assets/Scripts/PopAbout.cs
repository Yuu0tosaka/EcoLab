using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PopAbout : MonoBehaviour
{
    public GameObject pop_up_about;
    Animator anim;

    void Start()
    {
        anim = gameObject.GetComponent<Animator>();
    }

    public void Pop()
    {
        pop_up_about.SetActive(true);
    }

    public void PopIn()
    {
        anim.SetTrigger("hide");
    }
}
