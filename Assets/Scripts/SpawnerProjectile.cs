using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerProjectile : MonoBehaviour, ISpawner
{

    private GameObject spawnedObject {get; set;}


    public void Spawn(GameObject spawnedObject) {
        Quaternion rotation = transform.rotation;
        Instantiate(spawnedObject, transform.position, rotation);
    }

}
