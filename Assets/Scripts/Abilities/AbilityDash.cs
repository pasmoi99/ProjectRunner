using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbilityDash : Ability
{
    [SerializeField] float DashForce;
    Vector3 Force;
    // Start is called before the first frame update
    void Start()
    {
        Force = new Vector3(DashForce,0 , 0);
    }

    // Update is called once per frame
    void Update()
    {

    }

    override public void OnActionButtonPressed()
    {
        MainGame.Instance.Player.GetPlayerRigidBody().velocity = Vector3.zero;
        MainGame.Instance.Player.GetPlayerRigidBody().AddForce(Force, ForceMode2D.Impulse);
    }
}