using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Char_ShootingController : MonoBehaviour
{
    [SerializeField] private Transform _bulletOrigin;
    [SerializeField] private GameObject _bullet;
    [SerializeField] private bool startWithEndlessFire = true;

    private void Start()
    {
        
        if(startWithEndlessFire) StartCoroutine("EndlessFire");
    }

    public void Fire() {

        GameObject bullet = Instantiate(_bullet, _bulletOrigin.position, _bulletOrigin.rotation);
    }

    IEnumerator EndlessFire() {

        while (true) {
            yield return new WaitForSeconds(Random.Range(.1f,1));
            Fire();
        }
    }
}
