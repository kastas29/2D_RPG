using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour
{
    GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = player.transform.position + new Vector3(0, 0, -5);
        //Vector3 playerTransform = player.transform.position;
        //playerTransform.z = -10;

        //transform.position = Vector3.Lerp(transform.position, playerTransform, 2f * Time.deltaTime);
    }
}
