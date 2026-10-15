using UnityEngine;

public class SimpleSpawner : MonoBehaviour
{
    public GameObject objectToSpawn; // Префаб, который нужно спавнить
    public float spawnInterval = 2f; // Интервал в секундах
    private float timer;

    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= spawnInterval)
        {
            SpawnObject();
            timer = 0f;
        }
    }

    void SpawnObject()
    {
        // Создает объект в позиции и с поворотом текущего скрипта
        Instantiate(objectToSpawn, transform.position, transform.rotation);
    }
}