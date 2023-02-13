using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

//Adapted from https://github.com/SebLague/Create-a-Game-Source/blob/master/Episode%2001/PlayerController.cs on 4/19/20

[RequireComponent (typeof (Rigidbody))]
public class PlayerController : MonoBehaviour{
    Vector3 velocity;
    Rigidbody myRigidbody;
    void Start(){
        myRigidbody = GetComponent<Rigidbody> ();
    }

    public void Move(Vector3 _velocity){
        velocity = _velocity;
    }

    public void FixedUpdate(){
        myRigidbody.MovePosition (myRigidbody.position + velocity * Time.fixedDeltaTime);
    }
}
