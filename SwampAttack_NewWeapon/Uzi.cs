using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Uzi : Weapon
{
    private float _shootTime;
    private bool _isCanShoot;

    public override void Reset()
    {
        _shootTime = 0;
        _isCanShoot = true;
    }

    public override void Shot(Transform shootPoint, float shootingTime)
    {
        if (_isCanShoot)
        {
            Instantiate(Bullet, shootPoint.position, Quaternion.identity);
            _shootTime = shootingTime;
            _isCanShoot = false;
        }

        if (shootingTime - _shootTime >= _delay)
            _isCanShoot = true;
    }

    public override void StopShot(float stopShootingTime) { }
}
