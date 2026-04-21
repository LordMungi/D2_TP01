using UnityEngine;

public class Planet : MonoBehaviour
{
    [SerializeField] GameObject orbitPoint;
    [SerializeField] float orbitSpeed;
    [SerializeField] float rotationSpeed;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.RotateAround(orbitPoint.transform.position, Vector3.up, orbitSpeed * Time.deltaTime);
        transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime);
    }
}
