using UnityEngine;

public class Coins : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        other.tag = "Player";
        Debug.Log("Coin Added");
        gameObject.SetActive(false);
            
    }
}
