using UnityEngine;

public class CubeJump : MonoBehaviour
{
    public float jumpForce = 5f; // Сила прыжка
    private Rigidbody rb;

    void Start()
    {
        // Получаем компонент Rigidbody
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        // Проверяем, нажата ли клавиша пробела
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Применяем силу вверх
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
    }
}