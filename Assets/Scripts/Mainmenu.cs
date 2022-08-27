using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Mainmenu : MonoBehaviour
{
    public void Update()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }
    // Start is called before the first frame update

    public void PlayGame()
    {
        SceneManager.LoadScene(1);
        Cursor.visible = false;
        Debug.Log("Level1");
    }
    public void LeaveGame()
    {
        Application.Quit();
    }
    public void Controls()
    {
        SceneManager.LoadScene(5);
    }
}
