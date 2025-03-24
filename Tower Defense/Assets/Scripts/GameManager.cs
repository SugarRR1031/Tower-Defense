using UnityEngine;

public class GameManager : MonoBehaviour
{

    public static GameManager Instance;

    public float enemyTimer = 0f;
    public float spawnInterval = 1f;

    public Vector2 xBounds;
    public Vector2 yBounds;


    private void Awake()
    {
        if (Instance == null) 
        { 
            DontDestroyOnLoad(gameObject);
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        enemyTimer += Time.deltaTime;
        Vector3 targetPos = new Vector3(Random.Range(xBounds.x, xBounds.y), Random.Range(yBounds.x, yBounds.y), 0);

        if (enemyTimer >= spawnInterval)
        {
            enemyTimer = 0;
            Instantiate(enemy, targetPos, Quaternion.identity);
        }
    }
}
