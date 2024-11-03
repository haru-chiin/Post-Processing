using System.Collections.Generic;
using UnityEngine;

public class RoadGenerator : MonoBehaviour
{
    public GameObject roadPrefab;
    public Transform player;
    public float roadLength = 2087.13f;
    public int initialRoadCount = 3;

    private List<GameObject> activeRoads = new List<GameObject>();
    private float spawnZ = 0.0f;
    private int roadsOnScreen = 0;

    private void Start()
    {
        for (int i = 0; i < initialRoadCount; i++)
        {
            SpawnRoad();
        }
    }

    private void Update()
    {
        if (player.position.z - roadLength > activeRoads[0].transform.position.z)
        {
            SpawnRoad();
            DeleteOldestRoad();
        }
    }

    private void SpawnRoad()
    {
        GameObject newRoad = Instantiate(roadPrefab, new Vector3(0, 0, spawnZ), Quaternion.identity);
        activeRoads.Add(newRoad);
        spawnZ += roadLength;
        roadsOnScreen++;
    }

    private void DeleteOldestRoad()
    {
        Destroy(activeRoads[0]);
        activeRoads.RemoveAt(0);
        roadsOnScreen--;
    }
}
