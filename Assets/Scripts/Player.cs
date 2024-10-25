using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class Player : MonoBehaviour
{
    [SerializeField] float _Speed = 0.5f;
    [SerializeField] float _GroundDetectorOffset = 0.5f;
    [SerializeField] float _GroundDetectorRadius = 0.5f;
    [SerializeField] LayerMask _GroundLayer;
    int _ActiveAbility = 0;
    int _MaxAbilities=0;
    bool _IsGrounded { get; set; }
    Rigidbody2D _PlayerRigidBody { get; set; }
    // Start is called before the first frame update
    void Start()
    {
        _MaxAbilities = MainGame.Instance.Abilities.Count;
        _PlayerRigidBody = GetComponent<Rigidbody2D>();

    }
    
    // Update is called once per frame
    void Update()
    {
        //if (PlayerRigidBody.)
        //{
            
        //}
        transform.position += new Vector3(_Speed, 0, 0);
        if (GetActionButtonPressed() && _ActiveAbility <= _MaxAbilities-1)
        {
            if (MainGame.Instance.Abilities[_ActiveAbility] != null)
            {
                ActionButtonPressed(MainGame.Instance.Abilities[_ActiveAbility]);
                _ActiveAbility++;
            }
            else 
            {
                _ActiveAbility++;
            }
        }
    }

    public Rigidbody2D GetPlayerRigidBody()
    {
        return _PlayerRigidBody;
    }

    void ActionButtonPressed(Ability ability)
    {
        ability.OnActionButtonPressed();
    }
    bool GetActionButtonPressed()
    {
        return Input.GetKeyDown("e");
    }

    public bool GetIsGrounded()
    {
        return _IsGrounded;
    }

    private void OnDrawGizmos()
    {
        Gizmos.DrawSphere(transform.position + Vector3.up * _GroundDetectorOffset, _GroundDetectorRadius);
    }

    void HandleGrounded()
    {
        Vector2 Point = (Vector2)(transform.position + Vector3.up * _GroundDetectorOffset);
        int CurrentGrounded = Physics2D.OverlapCircleNonAlloc(Point, _GroundDetectorRadius, MainGame.Instance.GroundColliders, (int)_GroundLayer);
        _IsGrounded = CurrentGrounded > 0;

    }
}
