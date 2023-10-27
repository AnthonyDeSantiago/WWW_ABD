using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileSimple : MonoBehaviour, IProjectile
{
    public float speed = 10f;
    public float damage;

    public Vector3 directionVector {get; set;}

    public void Move()
    {
        Vector3 movement = directionVector * speed * Time.deltaTime;
        transform.Translate(movement, Space.World);
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
        Move();
    }
}
