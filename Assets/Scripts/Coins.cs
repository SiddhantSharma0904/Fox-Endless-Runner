using UnityEngine;

public class Coins : MonoBehaviour
{
    //public Transform transform;
    
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        //Debug.Log("Coin Added");
        gameObject.SetActive(false);
            
    }
}
