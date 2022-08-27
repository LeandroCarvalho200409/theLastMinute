using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shoot : MonoBehaviour
{
    public float damage = 10f;
    public float range = 100f;
    public bool actshoot = false;
    public Weaponswitch weapon;
    public int Enemymesh;
    public bool Enemyhit = false;
    public GameObject bullet;
    public float speed = 100f;
    public Rigidbody instbulletrb;

    public Camera fpsCam;
    // Start is called before the first frame update
    void Start()
    {
        weapon = GameObject.Find("Hand.r_end").GetComponent<Weaponswitch>();
        Enemymesh = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            if(weapon.weaponSelected == 2)
            {
                IsShooting();
                bullet = Instantiate(bullet, transform.position, Quaternion.identity) as GameObject;
                instbulletrb = bullet.GetComponent<Rigidbody>();
                instbulletrb.AddForce(Vector3.forward * speed);
            }
            ;
        }
    }
    public void IsShooting()
    {
        RaycastHit hit;
        if (Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, range))
        {
            Debug.Log(hit.transform.name);
            if(hit.transform.name == "Character1")
            {
                Enemymesh = 1;
            }
            if (hit.transform.name == "Character2")
            {
                Enemymesh = 2;
            }
            if (hit.transform.name == "Character3")
            {
                Enemymesh = 3;
            }
            if (hit.transform.name == "Character4")
            {
                Enemymesh = 4;
            }
            if (hit.transform.name == "Character5")
            {
                Enemymesh = 5;
            }
            if (hit.transform.name == "Character6")
            {
                Enemymesh = 6;
            }
            if (hit.transform.name == "Character7")
            {
                Enemymesh = 7;
            }
            if (hit.transform.name == "Character8")
            {
                Enemymesh = 8;
            }
            if (hit.transform.name == "Character9")
            {
                Enemymesh = 9;
            }
            if (hit.transform.name == "Character10")
            {
                Enemymesh = 10;
            }
            if (hit.transform.name == "Character11")
            {
                Enemymesh = 11;
            }

        }
    }
}
