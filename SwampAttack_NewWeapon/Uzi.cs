using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Uzi : Weapon
{
    public override void Reset()
    {
        ShootTime = 0;
        IsCanShoot = true;
    }

    public override void StartShoting(Transform shootPoint, float shootingTime)
    {
        if (IsCanShoot)
        {
            Instantiate(Bullet, shootPoint.position, Quaternion.identity);
            ShootTime = shootingTime;
            IsCanShoot = false;
        }

        if (shootingTime - ShootTime >= Delay)
            IsCanShoot = true;
    }

    public override void StopShooting(float stopShootingTime) { }
}
