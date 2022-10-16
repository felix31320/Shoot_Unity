using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class loop : MonoBehaviour
{
    public GameObject centre;
    void Start()
    {
       
    }
   

    // Update is called once per frame
    void Update()
    {
        centre.transform.Rotate(0, 0, 100 * Time.deltaTime, Space.Self);
    }
}
