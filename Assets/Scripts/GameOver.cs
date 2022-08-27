using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public Playermovementcontroler pm;

    void Update()
    {
        NoHealth();  
    }

    public void NoHealth()
    {
        pm = gameObject.GetComponent<Playermovementcontroler>();

        if(pm.currenthealth <= 0)
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            SceneManager.LoadScene(3);
        }
    }

    public void Restart()
    {
        SceneManager.LoadScene(0);
    }
    public void Exit()
    {
        Application.Quit();
    }

}
