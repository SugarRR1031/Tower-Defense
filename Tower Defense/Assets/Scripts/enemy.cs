using UnityEditor.Build.Content;
using UnityEngine;
using UnityEngine.Rendering;

public class enemy : MonoBehaviour
{

    public float speed;
    public float xSpeed;
    public float ySpeed;

    public GameObject thisObject;
    public float xDir = 0f;
    public float yDir = 0f;

    public GameManager manager;

    public float reverseTime = 0f;
    public float reverseInterval = 3.0f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        speed = Random.Range(xSpeed, ySpeed);
        //  speed = Random.Range(-1f, 1f);
        xDir = Random.Range(-1f, 1f);
        yDir = Random.Range(-1f, -1f);

        //  PlayerPrefs.transform.position += new Vector3(0, 1, 0);
    }

    // Update is called once per frame
    void Update()
    {
        manager = FindObjectOfType<GameManager>();
        thisObject.transform.position += new Vector3(xDir, yDir, 0);
        reverseTime += Time.deltaTime;
        if (reverseTime >= reverseInterval)
        {
            reverseTime = 0f;
            xDir = xDir * 1;
            yDir = yDir * 1;
        }


    }

    void OnTriggerEnter2D(Collider other)
    {
        if (other.tag == "Bomb") 
        {
            health = health - 5;
            Destroy(other.gameObject);
        }
    
    }
}
