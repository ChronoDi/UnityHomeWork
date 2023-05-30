using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pistol : Weapon
{

    public override void StartShoting(Transform shootPoint, float shootingTime)
    {
        if (shootingTime < Delay) 
        {
            shootingTime += Delay;
        }

        if (IsCanShoot && shootingTime - ShootTime >= Delay)
        {
            ShootTime = shootingTime;
            Instantiate(Bullet, shootPoint.position, Quaternion.identity);
            IsCanShoot = false;
        }
    }

    public override void StopShooting(float stopShootingTime)
    {
        IsCanShoot = true;
    }

    public override void Reset()
    {
        ShootTime = 0;
        IsCanShoot = true;
    }
}