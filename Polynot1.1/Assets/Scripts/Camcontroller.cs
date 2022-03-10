using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camcontroller : MonoBehaviour
{
    public GameObject firstpersoncamera;
    public GameObject cam2;
    public GameObject cam3;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Switch1"))
        {
            firstpersoncamera.SetActive(true);
            cam2.SetActive(false);
            cam3.SetActive(false);
        }
        if (Input.GetButtonDown("Switch2"))
        {
            firstpersoncamera.SetActive(false);
            cam2.SetActive(true);
            cam3.SetActive(false);
        }
        if (Input.GetButtonDown("Switch3"))
        {
            firstpersoncamera.SetActive(false);
            cam2.SetActive(false);
            cam3.SetActive(true);
        }
    }
}