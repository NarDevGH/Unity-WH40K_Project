using System.Collections;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] private float _damage = 25f;
    [SerializeField] private float _bulletSpeed = 2000f;
    [SerializeField] private float _lifeTime = 5f;
    private void Start()
    {
        GetComponent<Rigidbody>().AddForce(transform.forward * _bulletSpeed);

        StartCoroutine("DestroyAfterTime");
    }

    private IEnumerator DestroyAfterTime()
    {
        yield return new WaitForSeconds(_lifeTime);

        Destroy(gameObject);
    }

    private void OnTriggerEnter(Collider other)
    {
        if ( other.CompareTag("HitScan") ) {

            other.gameObject.GetComponent<NPC_DamageRegistration>().Damage(_damage, transform.forward);
        }

        Destroy(gameObject);
    }

}
