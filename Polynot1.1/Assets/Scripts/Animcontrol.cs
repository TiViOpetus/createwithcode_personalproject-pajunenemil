using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animcontrol : MonoBehaviour
{
    public GameObject theNPC;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("forward"))
        {
            theNPC.GetComponent<Animator>().Play("forward");
        }
        if (Input.GetButtonDown("back"))
        {
            theNPC.GetComponent<Animator>().Play("back");
        }
        if (Input.GetButtonDown("right"))
        {
            theNPC.GetComponent<Animator>().Play("right");
        }
        if (Input.GetButtonDown("left"))
        {
            theNPC.GetComponent<Animator>().Play("left");
        }
    }
}
