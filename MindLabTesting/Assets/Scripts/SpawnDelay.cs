using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnDelay : MonoBehaviour
{
    public int delay;
    public Transform spawnpoint;
    public Rigidbody furniture;

    public void Spawn()
    {
        Invoke("SpawnDelayed", delay);
    }

    public void SpawnDelayed()
    {
        Rigidbody RigidPrefab;
        RigidPrefab = Instantiate(furniture, spawnpoint.position, spawnpoint.rotation) as Rigidbody;
    }
}
