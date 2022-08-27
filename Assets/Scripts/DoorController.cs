using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : MonoBehaviour
{
    Animator animdoor;
    public Playermovementcontroler pm;
    // Start is called before the first frame update
    void Start()
    {
        pm = GameObject.Find("Player").GetComponent<Playermovementcontroler>();
        animdoor = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        Animate();
    }

    void Animate()
    {
        if (pm.openDoor1 == true && Input.GetKeyDown(KeyCode.O))
        {
            Debug.Log("opendoor1 = True");
            animdoor.SetTrigger("opendoor1");
        }
        if (pm.openDoor2 == true && Input.GetKeyDown(KeyCode.O))
        {
            animdoor.SetTrigger("opendoor2");
        }
        if (pm.openDoor3 == true && Input.GetKeyDown(KeyCode.O))
        {
            animdoor.SetTrigger("opendoor3");
        }
        if(Input.GetKeyUp(KeyCode.O))
        {
            animdoor.ResetTrigger("opendoor1");
            animdoor.ResetTrigger("opendoor2");
            animdoor.ResetTrigger("opendoor3");
            animdoor.SetTrigger("opendoor_idle");
        }
    }
}
