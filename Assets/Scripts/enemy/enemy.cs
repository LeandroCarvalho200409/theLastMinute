using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using System.Threading;

public class enemy : MonoBehaviour
{
    private NavMeshAgent nav;
    public GameObject Player;
    public float OnDistanceRun = 10.0f;
    public float OnDistanceStop = 4.0f;
    public shoot shootScript;
    public float damage;
    public bool Enemyshooting;
    public bool IsShooting;
    public Transform playertrans;

    public GameObject bullet;
    public Transform bulletpos;
    
    
    public float maxhealth1;
    public float currenthealth1;

    public float maxhealth2;
    public float currenthealth2;

    public float maxhealth3;
    public float currenthealth3;

    public float maxhealth4;
    public float currenthealth4;

    public float maxhealth5;
    public float currenthealth5;

    public float maxhealth6;
    public float currenthealth6;

    public float maxhealth7;
    public float currenthealth7;

    public float maxhealth8;
    public float currenthealth8;

    public float maxhealth9;
    public float currenthealth9;

    public float maxhealth10;
    public float currenthealth10;

    public float maxhealth11;
    public float currenthealth11;

    public GameObject enemy1;
    public GameObject enemy2;
    public GameObject enemy3;
    public GameObject enemy4;
    public GameObject enemy5;
    public GameObject enemy6;
    public GameObject enemy7;
    public GameObject enemy8;
    public GameObject enemy9;
    public GameObject enemy10;
    public GameObject enemy11;

    public float fireRate = 2f;
    public float fireCountdown = 0f;

    public Bullet bulletscript;

    // Start is called before the first frame update
    void Start()
    {

        nav = GetComponent<NavMeshAgent>();
        maxhealth1 = 120.0f;
        currenthealth1 = 120.0f;

        maxhealth2 = 120.0f;
        currenthealth2 = 120.0f;

        maxhealth3 = 120.0f;
        currenthealth3 = 120.0f;

        maxhealth4 = 120.0f;
        currenthealth4 = 120.0f;

        maxhealth5 = 120.0f;
        currenthealth5 = 120.0f;

        maxhealth6 = 120.0f;
        currenthealth6 = 120.0f;

        maxhealth7 = 120.0f;
        currenthealth7 = 120.0f;

        maxhealth8 = 120.0f;
        currenthealth8 = 120.0f;

        maxhealth9 = 120.0f;
        currenthealth9 = 120.0f;

        maxhealth10 = 120.0f;
        currenthealth10 = 120.0f;

        maxhealth11 = 120.0f;
        currenthealth11 = 120.0f;


        damage = 40.0f;

        Enemyshooting = false;

        bulletscript = bullet.GetComponent<Bullet>();
    }

    // Update is called once per frame
    void Update()
    {
        bulletscript.enemyvector3 = gameObject.transform.position;
        
        float distance = Vector3.Distance(transform.position, Player.transform.position);

        if(distance < OnDistanceRun)
        {
            Vector3 dirToPlayer = transform.position - Player.transform.position;
            Vector3 newPos = transform.position - dirToPlayer;
            nav.SetDestination(newPos);
            nav.isStopped = false;
            Enemyshooting = false;
            IsShooting = false;

            if(distance <= OnDistanceStop)
            {
                nav.isStopped = true;
                if (fireCountdown <= 0f)
                {
                    shoot();
                    fireCountdown = 1f / fireRate;
                }

                fireCountdown -= Time.deltaTime;

            }
        }
        IsDead();
        if (Input.GetMouseButtonDown(0))
        {
            Ishit();
        }
    }

    public void shoot()
    {
        GameObject bulletGO = (GameObject) Instantiate(bullet, bulletpos.position, bulletpos.rotation);
        Bullet bulletscript = bulletGO.GetComponent<Bullet>();

        if(bulletscript != null)
        {
            bulletscript.Seek(playertrans);
        }
       
    }
    void Ishit()
    {
        if(shootScript.Enemymesh == 1)
        {
            currenthealth1 = currenthealth1 - damage;
        }
        if (shootScript.Enemymesh == 2)
        {
            currenthealth2 = currenthealth2 - damage;
        }
        if (shootScript.Enemymesh == 3)
        {
            currenthealth3 = currenthealth3 - damage;
        }
        if (shootScript.Enemymesh == 4)
        {
            currenthealth4 = currenthealth4 - damage;
        }
        if (shootScript.Enemymesh == 5)
        {
            currenthealth5 = currenthealth5 - damage;
        }
        if (shootScript.Enemymesh == 6)
        {
            currenthealth6 = currenthealth6 - damage;
        }
        if (shootScript.Enemymesh == 7)
        {
            currenthealth7 = currenthealth7 - damage;
        }
        if (shootScript.Enemymesh == 8)
        {
            currenthealth8 = currenthealth8 - damage;
        }
        if (shootScript.Enemymesh == 9)
        {
            currenthealth9 = currenthealth9 - damage;
        }
        if (shootScript.Enemymesh == 10)
        {
            currenthealth10 = currenthealth10 - damage;
        }
        if (shootScript.Enemymesh == 11)
        {
            currenthealth11 = currenthealth11 - damage;
        }
    }
    void IsDead()
    {
        if(currenthealth1 <= 0)
        {
            enemy1.SetActive(false);
        }
        if (currenthealth2 <= 0)
        {
            enemy2.SetActive(false);
        }
        if (currenthealth3 <= 0)
        {
            enemy3.SetActive(false);
        }
        if (currenthealth4 <= 0)
        {
            enemy4.SetActive(false);
        }
        if (currenthealth5 <= 0)
        {
            enemy5.SetActive(false);
        }
        if (currenthealth6 <= 0)
        {
            enemy6.SetActive(false);
        }
        if (currenthealth7 <= 0)
        {
            enemy7.SetActive(false);
        }
        if (currenthealth8 <= 0)
        {
            enemy8.SetActive(false);
        }
        if (currenthealth9 <= 0)
        {
            enemy9.SetActive(false);
        }
        if (currenthealth10 <= 0)
        {
            enemy10.SetActive(false);
        }
        if (currenthealth11 <= 0)
        {
            enemy11.SetActive(false);
        }
    }

}
