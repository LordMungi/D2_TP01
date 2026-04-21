using UnityEngine;

public class Ship : MonoBehaviour
{
    [SerializeField] private float SPEED;
    [SerializeField] private float SENSITIVITY;

    [SerializeField] private GameObject bullet;
    [SerializeField] private GameObject bulletSpawnPosition;
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"), Input.GetAxisRaw("Forward")) * SPEED * Time.deltaTime);
        transform.rotation *= Quaternion.AngleAxis(SENSITIVITY * Time.deltaTime, new Vector3(-Input.GetAxisRaw("Mouse Y"), Input.GetAxisRaw("Mouse X"), -Input.GetAxisRaw("Roll")));

        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(bullet, bulletSpawnPosition.transform.position, transform.rotation);
        }
    }
}
