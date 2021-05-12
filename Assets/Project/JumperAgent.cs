using System;
using System.Collections;
using System.Collections.Generic;
using Unity.MLAgents;
using Unity.MLAgents.Actuators;
using Unity.MLAgents.Sensors;
using UnityEngine;

public class JumperAgent : Agent
{
    private Rigidbody rb;
    [SerializeField] private float force;


    public override void OnEpisodeBegin()
    {
        transform.localPosition = Vector3.zero;
    }

    public override void Initialize()
    {

        rb = GetComponent<Rigidbody>();
        
    }

    public override void OnActionReceived(ActionBuffers actions)
    {
        float act = actions.ContinuousActions[0];
        rb.AddForce(transform.up*force*act,ForceMode.Acceleration);
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Obstacle"))
        {
            AddReward(-1f);
            EndEpisode();
        }
        else if (other.gameObject.CompareTag("Ceiling"))
        {
            AddReward(-1f);
            EndEpisode();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("RewardWall"))
        {
            AddReward(0.1f);
        }
    }
}