
using UnityEngine;

public class gun : MonoBehaviour
{

    private Animator anim;
    public float damage = 10f;
    public float range = 100f;
    public int bulletsPerMag = 30; //panokset jokaisessa lippaassa
    public int bulletsleft = 200; //jäljellä olevat panokset
    public int currentBullets; //lippaassa olevat panokset

    public Transform shootpoint;

    public float fireRate = 0.1f; //jokaisen ammuksen välinen viive

    float fireTimer; //viiveen ajastin

    public Camera fpsCam;

    //public Rigidbody projectile; //ammus  
    //public float speed = 20;
    void Start()
    {
        anim = GetComponent<Animator>();
        currentBullets = bulletsPerMag;
    }
    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetButtonDown("Fire1"))
        {
           Fire();//aloittaa ampumaa kun hiiren vasenta painiketta painetaan
        }
       
        
       
        if (fireTimer < fireRate)
            fireTimer += Time.deltaTime;  //ajastin
    }

    void FixedUpdate()
    {
        AnimatorStateInfo info = anim.GetCurrentAnimatorStateInfo(0);

        if (info.IsName("Firing With Rifle")) anim.SetBool("Firing With Rifle", false);
    }




    private void Fire()
    {
        if (fireTimer < fireRate) return;

        RaycastHit hit;

        if(Physics.Raycast(shootpoint.position, shootpoint.transform.forward,out hit, range))
        {
            Debug.Log(hit.transform.name + " found!");
        }

        anim.SetBool("Firing Rifle", true);

        currentBullets--;
        fireTimer = 0.0f; //nollaa ajastimen
    }
}