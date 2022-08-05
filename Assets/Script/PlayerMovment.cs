using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 控制玩家移动
/// </summary>
[RequireComponent(typeof(CharacterController))]
public class PlayerMovment : MonoBehaviour
{
    private CharacterController CharacterController;

    public float Speed = 1f;
    public Vector2 moveDirection;
    private float mHorizontal;
    private float mVertical;

    private void Start()
    {
        if(this.CharacterController == null)
        {
            this.CharacterController = this.GetComponent<CharacterController>();
        }

    }

    private void Update()
    {
        this.Move();
    }

    public void Move()
    {
       this.mHorizontal = Input.GetAxis("Horizontal");
        this.mVertical = Input.GetAxis("Vertical");


        this.moveDirection = this.Speed * (this.transform.right * this.mHorizontal + this.transform.forward * this.mVertical).normalized;
        this.CharacterController.Move(this.moveDirection);
        Debug.Log($"fHorizontal = {this.mHorizontal}, fVertical = {this.mVertical}");
    }
}
