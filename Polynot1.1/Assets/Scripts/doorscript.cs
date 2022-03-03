using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doorscript : MonoBehaviour

{
    private Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        
    }


    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        animator.SetBool("Opened", true);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
