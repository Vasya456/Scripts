using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(BoxCollider2D))]

public class PlayerShip : Ship
{
      
    private void Update()
    {
        RangePosition();
        PlayerMoveShip();
    }


    protected override void PlayerMoveShip()
    {
        base.PlayerMoveShip();
    }

    protected override void RangePosition()
    {
        base.RangePosition();
    }


}
