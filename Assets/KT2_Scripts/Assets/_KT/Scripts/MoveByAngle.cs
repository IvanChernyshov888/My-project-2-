using UnityEngine;

public class MoveByAngle : MonoBehaviour
{
    [Header("Настройки движения")]
    public float speed = 5f;        // Скорость движения
    public float angle = 45f;       // Угол движения в градусах (0 — вправо)
    public bool is2D = true;        // true для 2D (вверх/вниз), false для 3D (вперед/назад)

    private Vector3 moveDirection;

    void Start()
    {
        // Переводим угол из градусов в радианы
        float radians = angle * Mathf.Deg2Rad;

        // Вычисляем направление на основе тригонометрии
        if (is2D)
        {
            // Для 2D: X — влево/вправо, Y — вверх/вниз
            moveDirection = new Vector3(Mathf.Cos(radians), Mathf.Sin(radians), 0f);
        }
        else
        {
            // Для 3D: X — влево/вправо, Z — вперед/назад
            moveDirection = new Vector3(Mathf.Cos(radians), 0f, Mathf.Sin(radians));
        }
    }

    void Update()
    {
        // Двигаем объект каждый кадр с учетом скорости и времени
        transform.Translate(moveDirection * speed * Time.deltaTime, Space.World);
    }
}
