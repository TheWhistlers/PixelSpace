using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour
{
    [Header("Move Arguments")]
    public float Velocity = 5f;
    public Slider MoveDirectionSlider;

    [Header("Jump Arguments")]
    public LayerMask Ground;
    public bool IsGrounded;
    protected Rigidbody2D rb;
    public float Bounce = 5f;

    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
        MoveDirectionSlider = GameObject.Find("player_movement_slider").GetComponent<Slider>();
    }

    void FixedUpdate()
    {
        Movement();
    }
    public void Movement()
    {
        RaycastHit2D hit = RaycastHelper.CreateRaycast(gameObject, new Vector2(0f, 0f), Vector2.down, 1.5f, Ground);
        
        if (hit)
            IsGrounded = true;
        else
            IsGrounded = false;

        // 当移动速度很小时自动归零
        if (MathF.Abs(MoveDirectionSlider.value) <= 0.25f)
            MoveDirectionSlider.value = 0;

        transform.Translate(MoveDirectionSlider.value * Velocity * Time.deltaTime, 0, 0);
        //if (MoveSlider.value != 0)
            //Model.transform.localScale = new Vector3(-MoveSlider.value, 1, 0);
    }

    public void Jump()
    {
        if (IsGrounded)
        {
            this.rb.AddForce(Bounce * Vector2.up, ForceMode2D.Impulse);
        }
    }
}
