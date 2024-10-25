using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class MainGame : MonoBehaviour
{
    public static MainGame Instance { get; private set; }
    public int NumberGroundObjects;
    public Player Player;
    public Collider2D[] GroundColliders;

    //private int _curentGround = 0;
    //public int AbilitySlots { get; } = 0;

    public List<Ability> Abilities = new List<Ability>();

    private void Awake()
    {
        Instance = this;
        GroundColliders = new Collider2D[NumberGroundObjects];
    }
    //public int GetCurrentGround()
    //{
    //    return _curentGround;
    //}

    //public void SetCurrentGround()
    //{
    //    _curentGround++;
    //}
}
;