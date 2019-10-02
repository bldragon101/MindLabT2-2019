using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObject : MonoBehaviour
{
    public Transform spawnpoint;
    public Rigidbody furniture;
    private float spawnDelay = 3;

    public void Spawn()
    {
        Rigidbody RigidPrefab;
        RigidPrefab = Instantiate(furniture, spawnpoint.position, spawnpoint.rotation)as Rigidbody;
    }
}
