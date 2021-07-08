using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserBolt : MonoBehaviour
{
    public float laserSpeed = 2000f;

    private void Start()
    {
        StartCoroutine("DestroyAfterTime");
    }

    private IEnumerator DestroyAfterTime() {
        yield return new WaitForSeconds(5);

        Destroy(gameObject);
    }

    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
    }
}
