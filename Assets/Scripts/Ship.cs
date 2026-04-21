using UnityEngine;

public class Ship : MonoBehaviour
{
    [SerializeField] float SPEED;
    [SerializeField] float SENSITIVITY;
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
    }
}
