using UnityEngine;

public class PrefabSpawner : MonoBehaviour
{
    public GameObject prefab; // 生成するPrefab
    public int numberOfPrefabs = 10; // 生成するPrefabの数
    public float spacing = 5.0f; // 等間隔の距離

    void Start()
    {
        SpawnPrefabs();
    }

    void SpawnPrefabs()
    {
        for (int i = 0; i < numberOfPrefabs; i++)
        {
            Vector3 spawnPosition = transform.position + transform.right * i * spacing;
            GameObject spawnedPrefab = Instantiate(prefab, spawnPosition, Quaternion.identity);
        }
    }
}
