using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animcontrol : MonoBehaviour
{
    public GameObject firstpersonplayer;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("forward"))
        {
            firstpersonplayer.GetComponent<Animator>().Play("forward");
        }
        if (Input.GetButtonDown("back"))
        {
            firstpersonplayer.GetComponent<Animator>().Play("back");
        }
        if (Input.GetButtonDown("right"))
        {
            firstpersonplayer.GetComponent<Animator>().Play("right");
        }
        if (Input.GetButtonDown("left"))
        {
            firstpersonplayer.GetComponent<Animator>().Play("left");
        }
    }
}
