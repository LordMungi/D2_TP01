using UnityEngine;

public class Ship : MonoBehaviour
{
    [SerializeField] float SPEED;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"), Input.GetAxisRaw("Forward")) * SPEED * Time.deltaTime);
    }
}
