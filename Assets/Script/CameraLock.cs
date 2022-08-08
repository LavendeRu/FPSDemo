using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 控制摄像机
/// 玩家左右旋转控制实现镜头左右旋转
/// 摄像机上下旋转控制镜头上下旋转
/// </summary>
public class CameraLock : MonoBehaviour
{
    public float mouseSensitivity = 100f;
    public Transform playerBody;

    private float mouseX;
    private float mouseY;

    private float xRotation = 0f;
    private float yRotation = 0f;

    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }
    private void Update()
    {
        this.mouseX = Input.GetAxis("Mouse X") * this.mouseSensitivity * Time.deltaTime;
        this.mouseY = Input.GetAxis("Mouse Y") * this.mouseSensitivity * Time.deltaTime;
        xRotation -= this.mouseY;
        xRotation = Mathf.Clamp(xRotation, -80f,80f);

        yRotation += this.mouseY;
        Debug.Log($"this.xRotation  = {this.xRotation },  this.yRotation = { this.yRotation}");
        this.transform.localRotation = Quaternion.Euler(yRotation, 0f, 0f);
        this.playerBody.Rotate(Vector3.up * this.mouseX);
    }

}
