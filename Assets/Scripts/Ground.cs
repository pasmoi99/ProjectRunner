using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ground : MonoBehaviour
{
    static int s_currentID = 0;

    Collider2D _Ground;
    int _id=0;


    // Start is called before the first frame update
    void Start()
    {
        _Ground = GetComponent<Collider2D>();
        MainGame.Instance.GroundColliders[_id] = _Ground;
        _id = s_currentID++;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
