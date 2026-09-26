using UnityEngine;

public class Obstacles : MonoBehaviour
{
    public GameObject ExplosionEffect;

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        gameObject.SetActive(false);
        Instantiate(ExplosionEffect, transform.position,Quaternion.identity);
    }
}
