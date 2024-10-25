using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    [SerializeField] float CameraOffsetX;
    [SerializeField] float CameraOffsetY;

    Transform playerTransform;
    // Start is called before the first frame update
    void Start()
    {
        playerTransform = MainGame.Instance.player.transform;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(playerTransform.position.x - CameraOffsetX, -CameraOffsetY, transform.position.z);
    }
}
