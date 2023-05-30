using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Weapon : MonoBehaviour
{
    [SerializeField] private string _label;
    [SerializeField] private int _price;
    [SerializeField] private Sprite _icon;
    [SerializeField] private bool _isBuyed = false;
    [SerializeField] protected float Delay;
    [SerializeField] protected Bullet Bullet;

    protected float ShootTime;
    protected bool IsCanShoot;
    public string Label => _label;
    public int Price => _price;
    public Sprite Icon => _icon;
    public bool IsBuyed => _isBuyed;

    public abstract void StartShoting(Transform shootPoint, float shootingTime);
    public abstract void StopShooting();
    public abstract void Reset();

    public void Buy()
    {
        _isBuyed = true;
    }
}