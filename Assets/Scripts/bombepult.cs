using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class bombepult : MonoBehaviour
{
    public Playermovementcontroler pm;
    public Transform player;
    public float dist;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        pm = GameObject.Find("Player").GetComponent<Playermovementcontroler>();

        dist = Vector3.Distance(player.position, transform.position);

        if(pm == null)
        {
            pm = GameObject.Find("Player").GetComponent<Playermovementcontroler>();
        }

        CheckDeactivate();
    }
    public void CheckDeactivate()
    {
        if(dist <= 5.0f && pm.laptop == true && Input.GetKeyDown(KeyCode.E))
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            SceneManager.LoadScene(4);
        }
    }
}
