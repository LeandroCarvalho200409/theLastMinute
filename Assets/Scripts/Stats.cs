using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Stats : MonoBehaviour
{
    public Playermovementcontroler pm;
    public float minutes = 5;
    public float secounds = 0;
    public Text health;
    public Text minutestxt;
    public Text secoundstxt;


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

        if(secounds <= 0)
        {
            minutes -= 1f;
            secounds = 60f;
        }

        secounds -= Time.deltaTime;

        if(minutes <= 0 && secounds <= 0)
        {
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
            SceneManager.LoadScene(3);
        }

        SetStats();
    }

    void SetStats()
    {
        health.text = pm.currenthealth.ToString();
        minutestxt.text = minutes.ToString();
        secoundstxt.text = secounds.ToString();
    }
}
