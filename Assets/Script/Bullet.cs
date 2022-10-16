using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float life = 3;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void Awake()
    {
        Destroy(gameObject,life);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("target")){
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
        
    }
}
