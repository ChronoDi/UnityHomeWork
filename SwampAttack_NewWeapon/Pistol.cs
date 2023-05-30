using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pistol : Weapon
{
    private bool _isCanShoot;
    private float _shootTime;

    public override void Shot(Transform shootPoint, float shootingTime)
    {

        if (_isCanShoot)
        {
            _shootTime = shootingTime;
            Instantiate(Bullet, shootPoint.position, Quaternion.identity);
            _isCanShoot = false;
        }
    }

    public override void StopShot(float stopShootingTime)
    {
        if (stopShootingTime - _shootTime >= _delay)
        {
            _isCanShoot = true;
        }
    }

    public override void Reset()
    {
        _shootTime = 0;
        _isCanShoot = true;
    }
}