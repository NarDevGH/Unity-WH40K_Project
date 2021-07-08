using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponController : MonoBehaviour
{
    [SerializeField] private float _damage;
    [SerializeField] private Transform _bulletOrigin;
    [SerializeField] private GameObject _bullet;
    [SerializeField] private GameObject _muzzleFlash;
    [SerializeField] private AudioSource _audioSource;

    private Animator animator;

    private bool fireEnabled;

    private void Awake()
    {
        animator = GetComponent<Animator>();
    }

    private void Start()
    {
        fireEnabled = false;
    }

    private void Update()
    {
        if (fireEnabled) {
            if (Input.GetKeyDown(KeyCode.Mouse0)) {
                fireEnabled = false;
                InstantiateBullet();
                _audioSource.Play();
                TriggerFireAnim();
            }
        }

    }
    public void EnableFire() { fireEnabled = true; } //Called by idle animation

    private void TriggerFireAnim() { animator.SetTrigger("Fire"); }

    private void InstantiateBullet() {
        GameObject laserBolt = Instantiate(_bullet, _bulletOrigin.position,_bulletOrigin.rotation);
        
        if(_muzzleFlash) Instantiate(_muzzleFlash, _bulletOrigin.position,_bulletOrigin.rotation);
    }

}
