using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class MainGame : MonoBehaviour
{
    public static MainGame Instance { get; private set; }

    public Player player;

    //public int AbilitySlots { get; } = 0;

    public List<Ability> Abilities = new List<Ability>();

    private void Awake()
    {
        Instance = this;
    }
}
;