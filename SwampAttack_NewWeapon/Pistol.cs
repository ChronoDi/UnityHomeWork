using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pistol : Weapon
{

    public override void StartShoting(Transform shootPoint, float triggerTime)
    {
        if (triggerTime < Delay) 
        {
            triggerTime += Delay;
        }

        if (IsCanShoot && triggerTime - ShootTime >= Delay)
        {
            ShootTime = triggerTime;
            Instantiate(Bullet, shootPoint.position, Quaternion.identity);
            IsCanShoot = false;
        }
    }

    public override void StopShooting()
    {
        IsCanShoot = true;
    }

    public override void Reset()
    {
        ShootTime = 0;
        IsCanShoot = true;
    }
}