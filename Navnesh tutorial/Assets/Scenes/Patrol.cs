using UnityEngine;

public class Patrol : MonoBehaviour
{
    public Collider patrolZone;
    public float speed = 3.0f;

    private Vector3 targetPosition;

    void Start()
    {
        
        NewTarget();
    }

    void Update()
    {
        // transform
        transform.position = Vector3.MoveTowards(transform.position, targetPosition, speed * Time.deltaTime);

        // if arrived 
        if (Vector3.Distance(transform.position, targetPosition) < 0.1f)
        {
            NewTarget();
        }
    }

    void NewTarget()
    {
        if (patrolZone == null) return;

        Bounds bounds = patrolZone.bounds;
        
        
        float randomX = Random.Range(bounds.min.x, bounds.max.x);
        float randomZ = Random.Range(bounds.min.z, bounds.max.z);

        
        targetPosition = new Vector3(randomX, transform.position.y, randomZ);
    }
}