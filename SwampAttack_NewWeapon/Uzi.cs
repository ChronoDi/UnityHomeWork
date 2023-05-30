using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Uzi : Weapon
{
    public override void Reset()
    {
        ShootTime = 0;
    }

    public override void StartShoting(Transform shootPoint, float shootingTime)
    {
        if (shootingTime < Delay)
        {
            shootingTime += Delay;
        }

        if (shootingTime - ShootTime >= Delay)
        {
            Instantiate(Bullet, shootPoint.position, Quaternion.identity);
            ShootTime = shootingTime;
        }
    }

    public override void StopShooting() { }
}
