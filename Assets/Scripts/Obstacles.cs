using UnityEngine;

public class Obstacles : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        other.tag = "Player";
        Debug.Log("Player Collided");
        gameObject.SetActive(false);
    }
}
