using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weaponswitch : MonoBehaviour
{
    public GameObject knife, gun;
    public int weaponSelected = 2;
    // Start is called before the first frame update
    void Start()
    {
        knife.SetActive(false);
        gun.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
