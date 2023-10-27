using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileSimple : MonoBehaviour, IProjectile
{

    float IProjectile.speed { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
    float IProjectile.damage { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }

    public void Move()
    {
        throw new System.NotImplementedException();
    }

    public void Rotate()
    {
        throw new System.NotImplementedException();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
