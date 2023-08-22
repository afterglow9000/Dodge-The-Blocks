using UnityEngine;

public class BlockSpawner : MonoBehaviour {

    public GameObject blockPrefab;
    public Transform[] spawnPoints;
    private float timeBetweenWaves = 1f;
    private float timeToSpawn = 2f;
    
	private void SpawnBlocks ()
    {
        int randomIndex = Random.Range(0, spawnPoints.Length);
        for (int i = 0; i < spawnPoints.Length; i++)
            if (randomIndex != i)
                Instantiate(blockPrefab, spawnPoints[i].position, Quaternion.identity);
	}
	
    private void Update ()
    {
        if (Time.time >= timeToSpawn)
        {
            SpawnBlocks();
            timeToSpawn = Time.time + timeBetweenWaves;
        }
    }
}
