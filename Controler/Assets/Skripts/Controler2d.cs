using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerControler : MonoBehaviour
{
    [SerializeField] private float movemenetSpeed;
    [SerializeField] private float jumpForcse;

    private Rigidbody2D rd;

    void Start()
    {
        rd = GetComponent<Rigidbody2D>();   
    }

    
    void Update()
    {
        //move logic
        float horizontalInput = Input.GetAxis("Horizontal");
        if (horizontalInput != 0)
        {
            Move(horizontalInput * movemenetSpeed);
        }
    } 
    private void OnAnimatorMove()
    {
        rd.AddForce(new Vector2(movemenetSpeed, 0));
    }
    private void jump()
}
