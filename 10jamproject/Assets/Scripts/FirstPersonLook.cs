using UnityEngine;

public class FirstPersonLook : MonoBehaviour
{
   public Transform character;

    //  public Transform character;
    public float mouseSensitivity = 100f;
    float xRotation = 0f;
    float xMin = -10f, xMax = 40f;





    void Start()
    {
        // Lock the mouse cursor to the game screen.
        Cursor.lockState = CursorLockMode.Locked;

    }

    void Update()


    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;




        xRotation -= mouseY;
       xRotation = Mathf.Clamp(xRotation, xMin, xMax);


        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
        character.Rotate(Vector3.up * mouseX);



    }


}
