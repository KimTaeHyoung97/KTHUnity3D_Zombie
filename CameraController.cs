using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    //Transform player;
    public Transform target;
    public Vector3 offset;
    // Start is called before the first frame update
    void Start()
    {
        //player = GameObject.Find("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        //Vector3 playerPos = player.transform.position;
        //transform.position = new Vector3(playerPos.x, transform.position.y,playerPos.z);
        transform.position = target.position + offset;
    }
}
