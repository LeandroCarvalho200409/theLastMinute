using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class laptop : MonoBehaviour
{
    public Playermovementcontroler pm;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        pm = GameObject.Find("Player").GetComponent<Playermovementcontroler>();

        if(pm == null)
        {
            pm = GameObject.Find("Player").GetComponent<Playermovementcontroler>();
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Player" || collision.gameObject.name == "fps_arms.animation")
        {
            pm.laptop = true;
            gameObject.SetActive(false);
        }
    }
}
