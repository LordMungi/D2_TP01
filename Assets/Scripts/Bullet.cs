using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] float SPEED;
    [SerializeField] float TIME_TO_DESTROY;

    float timePassed;
    void Start()
    {
        timePassed = 0.0f;
    }

    void Update()
    {
        if (timePassed >= TIME_TO_DESTROY)
            Destroy(gameObject);
     
        transform.position += transform.forward * SPEED * Time.deltaTime;
        timePassed += Time.deltaTime;
    }

}
