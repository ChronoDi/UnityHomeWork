using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Uzi : Weapon
{
    public override void Reset()
    {
        ShootTime = 0;
    }

    public override void StartShoting(Transform shootPoint, float triggerTime)
    {
        if (triggerTime < Delay)
        {
            triggerTime += Delay;
        }

        if (triggerTime - ShootTime >= Delay)
        {
            Instantiate(Bullet, shootPoint.position, Quaternion.identity);
            ShootTime = triggerTime;
        }
    }

    public override void StopShooting() { }
}
