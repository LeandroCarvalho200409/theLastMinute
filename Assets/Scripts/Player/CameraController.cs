using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField]
    Transform Player, FPS_Arms;

    public float SpeedH = 2.0f;
    public float SpeedV = 2.0f;

    public float yaw = 0.0f;
    public float pitch = 0.0f;

    [SerializeField]
    float mouseSensitivity;


    void Update()
    {
        yaw += SpeedH * Input.GetAxis("Mouse X");
        pitch -= SpeedV * Input.GetAxis("Mouse Y");

        transform.eulerAngles = new Vector3(0.0f, yaw, 0.0f);
        Player.transform.eulerAngles = new Vector3(0.0f, yaw, 0.0f);
        Cursor.lockState = CursorLockMode.Locked;
    }

}
