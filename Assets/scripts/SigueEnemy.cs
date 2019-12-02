using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SigueEnemy : MonoBehaviour
{
    public Transform objetivo;

    void FixedUpdate()
    {
        transform.LookAt(objetivo);

    }
    
}
