using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfinitePath : MonoBehaviour
{
    public GameObject path;
    [SerializeField] public float spawnDistance = 10f;
    private Vector3 nexSpawnPoint;

    private void Start()
    {
        nexSpawnPoint = transform.position;
        SpawnPath();
    }

    private void Update()
    {
        if (Vector3.Distance(transform.position, nexSpawnPoint) < spawnDistance) {
        SpawnPath();
        }
    }

    void SpawnPath()
    {
        GameObject newPath = Instantiate(path, nexSpawnPoint, Quaternion.identity );
        nexSpawnPoint = newPath.transform.position + Vector3.forward * spawnDistance;
    }
}
