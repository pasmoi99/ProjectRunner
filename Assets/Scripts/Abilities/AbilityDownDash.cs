using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbilityDownDash : Ability
{

    [SerializeField] float DownDashForce;

    Vector3 Force;
    // Start is called before the first frame update
    void Start()
    {
        Force = new Vector3(0, -DownDashForce, 0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public override void OnActionButtonPressed()
    {
        MainGame.Instance.Player.SetIsDashing(false);
        MainGame.Instance.Player.SetIsDownDashing(true);
        MainGame.Instance.Player.GetPlayerRigidBody().velocity = Vector3.zero;
        MainGame.Instance.Player.GetPlayerRigidBody().AddForce(Force, ForceMode2D.Impulse);
    }
}
