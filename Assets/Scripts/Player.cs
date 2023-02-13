using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

//Adapted from https://github.com/SebLague/Create-a-Game-Source/blob/master/Episode%2001/Player.cs on 4/19/20

[RequireComponent (typeof (PlayerController))]
public class Player : MonoBehaviour{


public float moveSpeed = 2;
PlayerController controller;
    void Start(){
        controller = GetComponent<PlayerController> ();
    }

    void Update()
    {
        Vector3 moveInput = new Vector3 (Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical"));
        Vector3 moveVelocity = moveInput.normalized * moveSpeed;
        controller.Move (moveVelocity);
    }

}
