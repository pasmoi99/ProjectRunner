using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class Player : MonoBehaviour
{
    [SerializeField] float Speed = 0.5f;
    int ActiveAbility = 0;
    int MaxAbilities=0;
    // Start is called before the first frame update
    void Start()
    {
        MaxAbilities = MainGame.Instance.Abilities.Count;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(Speed, 0, 0);
        if (Input.GetKeyDown("e") && ActiveAbility <= MaxAbilities-1)
        {
            if (MainGame.Instance.Abilities[ActiveAbility] != null)
            {
                ActionButtonPressed(MainGame.Instance.Abilities[ActiveAbility]);
                ActiveAbility++;
            }
            else 
            {
                ActiveAbility++;
            }
        }
    }

    void ActionButtonPressed(Ability ability)
    {
        ability.OnActionButtonPressed();
    }
}
