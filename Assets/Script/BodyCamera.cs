using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BodyCamera : MonoBehaviour
{
    private Rigidbody _rb;
    private float _speed = 2f;

    void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        MovePlayer();
    }

    private void MovePlayer()
    {
        if (Input.GetKey(KeyCode.Z))
        {
            _rb.AddForce(Vector3.forward * _speed, ForceMode.Force);
            
        }

        if (Input.GetKey(KeyCode.S))
        {
            _rb.AddForce(Vector3.back * _speed, ForceMode.Force);
        }

        if (Input.GetKey(KeyCode.D))
        {
            _rb.AddForce(Vector3.right * _speed, ForceMode.Force);
        }

        if (Input.GetKey(KeyCode.Q))
        {
            _rb.AddForce(Vector3.left * _speed, ForceMode.Force);
        }




    }
}
