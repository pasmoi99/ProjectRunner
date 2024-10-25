using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbilityDash : Ability
{
    [SerializeField] float DashForce;
    [SerializeField] float DashDuration;
    float DashTimerValue = 0;
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
        StartCoroutine(Dash(DashDuration));
        MainGame.Instance.Player.GetPlayerRigidBody().velocity = Vector3.zero;

    }

    IEnumerator Dash(float duration)
    {
        float gravity = MainGame.Instance.Player.GetPlayerRigidBody().gravityScale;
        for (float f=0;f<=duration; f+= Time.deltaTime)
        {
            MainGame.Instance.Player.GetPlayerRigidBody().gravityScale = 0;
            MainGame.Instance.Player.GetPlayerRigidBody().AddForce(Force, ForceMode2D.Force);

        }
        MainGame.Instance.Player.GetPlayerRigidBody().gravityScale = gravity;
        yield return null;
    }
}