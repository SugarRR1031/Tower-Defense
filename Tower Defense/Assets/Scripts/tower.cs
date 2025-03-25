using UnityEngine;

public class tower : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "enemy")
        {
            Debug.Log("collision with enemy");
            health = health - 10;
            Destroy(collision.gameObject);
        }
    }

}
