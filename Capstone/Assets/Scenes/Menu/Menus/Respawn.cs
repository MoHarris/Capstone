using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{
    [SerializeField] private Transform player;
    [SerializeField] private Transform RespawnPoint;

    private void OnTriggerEnter(Collider other)
    {
        player.transform.position = RespawnPoint.transform.position;
        ScoreScript.scoreValue -= 50;
    }
}
