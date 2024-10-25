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
    bool _isDashing { get; set; }
    bool _isDonwDashing { get; set; }
    bool _hasFinishedLevel { get; set; }
    Rigidbody2D _PlayerRigidBody { get; set; }
    // Start is called before the first frame update
    private void Awake()
    {
        _hasFinishedLevel = false;
    }
    void Start()
    {

        _MaxAbilities = MainGame.Instance.Abilities.Count;
        _PlayerRigidBody = GetComponent<Rigidbody2D>();

    }
    
    // Update is called once per frame
    void Update()
    {
        HandleGrounded();
        if (_IsGrounded || _isDashing)
        {
            _isDonwDashing = false;
        }
        if (!_isDonwDashing)
        {
            transform.position += new Vector3(_Speed, 0, 0);
        }
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



    public bool getIsDowndashing()
    {
        return _isDonwDashing;
    }
    public bool GetHasFinishedLevel()
    {
        return _hasFinishedLevel;
    }

    public void SetIsDashing(bool value)
    {
        _isDashing = value;
    }
    

    public void SetIsDownDashing(bool value)
    {
        _isDonwDashing = true;
    }

    private void OnDrawGizmos()
    {
        Gizmos.DrawSphere(transform.position + Vector3.up * _GroundDetectorOffset, _GroundDetectorRadius);
    }

    void HandleGrounded()
    {
        Vector2 Point = (Vector2)(transform.position + Vector3.up * _GroundDetectorOffset);
        bool CurrentGrounded = Physics2D.OverlapCircleNonAlloc(Point, _GroundDetectorRadius, MainGame.Instance.GroundColliders, (int)_GroundLayer) > 0;
        _IsGrounded = CurrentGrounded;

    }

}
//public enum ActiveState
//{

//}
