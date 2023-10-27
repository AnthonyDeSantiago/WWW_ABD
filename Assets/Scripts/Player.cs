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


    // Start is called before the first frame update
    void Start()
    {
        mainCamera = GameObject.FindWithTag("MainCamera").GetComponent<Camera>();
    }


    void Update() {
        Move();
        Rotate();
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
}
