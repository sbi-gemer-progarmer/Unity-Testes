using UnityEngine;

public class Camera_Movimentos : MonoBehaviour
{
    public Transform tr;
    [Header("Sensibilidade")]
    public float sensi = 100f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        tr = this.transform;
    }

    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * sensi * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * sensi * Time.deltaTime;

        tr.localRotation = Quaternion.Euler(mouseX, mouseY, 0);
        tr.Rotate(Vector3.up * mouseX);


    }
}
