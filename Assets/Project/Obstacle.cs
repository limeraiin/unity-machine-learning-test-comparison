using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class Obstacle : MonoBehaviour
{
    [SerializeField] private Transform spawn;
    [SerializeField]private float min;
    [SerializeField]private float max;
    private void FixedUpdate()
    {
        transform.Translate(new Vector3(16,0,0)*Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Respawn"))
        {
            transform.localPosition = spawn.localPosition+new Vector3(Random.Range(min,max),0,0); 
        }
       
    }

    private void OnCollisionEnter(Collision other)
    {
        transform.localPosition = spawn.localPosition+new Vector3(Random.Range(min,max),0,0); 
    }
}
