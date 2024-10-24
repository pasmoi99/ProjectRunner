using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    [SerializeField] float CameraOffset;

    Transform player;
    Vector3 CameraOffsetVector;
    // Start is called before the first frame update
    void Start()
    {
        player = MainGame.Instance.player.transform;
        CameraOffsetVector = new Vector3(CameraOffset,0,0);
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position = player.position + CameraOffsetVector;
    }
}
