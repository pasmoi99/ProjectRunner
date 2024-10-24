using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class Player : MonoBehaviour
{
    [SerializeField] float Speed = 0.5f;
    int ActiveAbility = 0;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(Speed, 0, 0);
        if (Input.GetKeyDown("e"))
        {
            ActionButtonPressed(MainGame.Instance.Abilities[0]);
        }
    }

    void ActionButtonPressed(Ability ability)
    {
        ability.OnActionButtonPressed();
    }
}
