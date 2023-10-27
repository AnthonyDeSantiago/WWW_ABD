using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Player : MonoBehaviour
{
    private Transform playerTransform;
    private Camera mainCamera;
    public float speed = 10f;
    public LayerMask floorLayer;
    public SpawnerProjectile spawner;
    public ProjectileSimple p;


    // Start is called before the first frame update
    void Start()
    {
        mainCamera = GameObject.FindWithTag("MainCamera").GetComponent<Camera>();
    }


    void Update() {
        Move();
        Rotate();
        float x = spawner.transform.position.x - transform.position.x;
        float y = spawner.transform.position.y - transform.position.y;
        float z = spawner.transform.position.z - transform.position.z;

        Vector3 directionVector = new Vector3(x, 0f, z);

        p.directionVector = directionVector;

        Fire(p);
    }

    void Move()
    {
        float horizontalInput = Input.GetAxisRaw("Horizontal");
        float verticalInput = Input.GetAxisRaw("Vertical");
        
        Vector3 inputDirection = new Vector3(horizontalInput, 0f, verticalInput);
        inputDirection = Vector3.Normalize(inputDirection);

        Vector3 movement = inputDirection * speed * Time.deltaTime;

        transform.Translate(movement, Space.World);
    }


    void Rotate() {
        Ray ray = mainCamera.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit, Mathf.Infinity, floorLayer)) {
            Vector3 targetPoint = hit.point;
            transform.LookAt(new Vector3(targetPoint.x, transform.position.y, targetPoint.z));
        }

    }

    void Fire(ProjectileSimple p) {
        spawner.Spawn(p);
    }
}
