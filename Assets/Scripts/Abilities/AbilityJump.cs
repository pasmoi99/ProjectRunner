using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbilityJump : Ability
{
    [SerializeField] float JumpForce;
    Vector3 Force;
    // Start is called before the first frame update
    void Start()
    {
        Force = new Vector3 (0, JumpForce, 0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    override public void OnActionButtonPressed()
    {
        if (MainGame.Instance.Player.GetIsGrounded())
        {
            MainGame.Instance.Player.GetPlayerRigidBody().velocity = Vector3.zero;
            MainGame.Instance.Player.GetPlayerRigidBody().AddForce(Force,ForceMode2D.Impulse);
        }
    }
}
