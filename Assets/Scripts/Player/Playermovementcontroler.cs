using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Playermovementcontroler : MonoBehaviour
{
    public float speed;
    public float walkspeed;
    public float sprintspeed;
    public float jumpSpeed;
    public Rigidbody rb;
    public Vector3 moveDirection;
    CharacterController controller;
    public float maxhealth = 100f;
    public float currenthealth = 100f;

    public bool openDoor1;
    public bool openDoor2;
    public bool openDoor3;
    public bool shoot;
    public bool laptop;

    public Weaponswitch weapon;
    public shoot shootScript;
    public Bullet bullet;



    Animator anim;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        jumpSpeed = 15f;
        speed = 0f;
        walkspeed = 4f;
        sprintspeed = 6f;
        anim = GetComponentInChildren<Animator>();
        controller = GetComponent<CharacterController>();

        weapon = GameObject.Find("Hand.r_end").GetComponent<Weaponswitch>();
        shootScript = GameObject.Find("Hand.r_end").GetComponent<shoot>();
        bullet = GameObject.Find("Sphere").GetComponent<Bullet>();
    }

    void Update()
    {
        Move();
        shootScript = GameObject.Find("Hand.r_end").GetComponent<shoot>();
        if(bullet = null)
        {
            bullet = GameObject.Find("Sphere").GetComponent<Bullet>();
        }
    }
    public void RemHealth()
    {
        currenthealth -= 5f;
        Debug.Log(currenthealth);
    }

    void Move()
    {
        
        float hAxis = Input.GetAxis("Horizontal");
        float vAxis = Input.GetAxis("Vertical");

        moveDirection = new Vector3(hAxis, 0, vAxis);
        moveDirection = transform.TransformDirection(moveDirection);

        if (Input.GetKey(KeyCode.LeftShift))
        {
            
            speed = sprintspeed;
        }
        else
        {
            speed = walkspeed;
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            
            moveDirection.y += jumpSpeed;
        }
        if(vAxis != 0)
        {
            anim.SetInteger("condition", 1);
        }
        if(vAxis == 0)
        {
            anim.SetInteger("condition", 0);
        }
        if (Input.GetMouseButtonDown(0))
        {
            if(weapon.weaponSelected == 1)
            {
                anim.SetTrigger("knife_Attack");
            }
               
        }
        

        moveDirection.y -= 0.5f;
        moveDirection *= (speed/30);
        controller.Move(moveDirection);

    }
    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Key0")
        {
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.name == "Key1")
        {
            openDoor1 = true;
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.name == "Key2")
        {
            openDoor2 = true;
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.name == "Key3")
        {
            openDoor3 = true;
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.name == "laptop")
        {
            laptop = true;
            Destroy(collision.gameObject);
        }
    }


}


