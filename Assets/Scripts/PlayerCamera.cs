using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCamera : MonoBehaviour
{   
    private GameObject player;
    private Transform playerTransform;
    public float offsetX = 10;
    public float offsetZ = 10;
    public float height = 10;
    private Vector3 currentPosition;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindWithTag("Player");
        playerTransform = player.GetComponent<Transform>();
        currentPosition = new Vector3(playerTransform.position.x + offsetX, height, playerTransform.position.z + offsetZ);
        transform.position = currentPosition;
    }

    // Update is called once per frame
    void Update()
    {
        currentPosition = new Vector3(playerTransform.position.x + offsetX, height, playerTransform.position.z + offsetZ);
        transform.position = currentPosition;
    }
}
