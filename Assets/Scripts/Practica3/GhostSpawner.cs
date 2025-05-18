using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GhostSpawner : MonoBehaviour
{

    public GameObject ghostPrefab;
    public Transform player;
    public float spawnInterval = 3f;
    public float spawnRadius = 10f;
    
    
    
    
    void Start()
    {
        InvokeRepeating(nameof(SpawnGhost), 2f, spawnInterval);
    }


    void SpawnGhost()
    {
        Vector3 spawnPos = player.position + Random.onUnitSphere * spawnRadius;
        spawnPos.y = player.position.y;
        GameObject ghost = Instantiate(ghostPrefab, spawnPos, Quaternion.identity);
        ghost.GetComponent<Ghost>().target = player;

    }


}
