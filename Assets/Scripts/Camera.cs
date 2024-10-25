using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    [SerializeField] float CameraOffsetX;

    Transform playerTransform;
    // Start is called before the first frame update
    void Start()
    {
        playerTransform = MainGame.Instance.Player.transform;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(playerTransform.position.x - CameraOffsetX, transform.position.y, transform.position.z);
    }
}
