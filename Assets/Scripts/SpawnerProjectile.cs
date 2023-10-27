using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerProjectile : MonoBehaviour, ISpawner
{

    public void Spawn(ProjectileSimple spawnedObject) {
        Quaternion rotation = transform.rotation;
        Instantiate(spawnedObject, transform.position, rotation);
    }

}
