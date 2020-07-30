using UnityEngine;

public class BlockSpawner : MonoBehaviour {

    public Transform[] spawnpoints;
    public GameObject blockPrefab;
    private float timetospawn = 2f;
    private float timebetweenwaves = 1f;
       

	// Use this for initialization
	void SpawnBlocks ()

    {
        int randomIndex = Random.Range(0, spawnpoints.Length);

        for (int i= 0; i< spawnpoints.Length; i++)
        {
            if(randomIndex != i)
            {
                Instantiate(blockPrefab, spawnpoints[i].position, Quaternion.identity);
            }
        }

	}


    // Update is called once per frame
    void FixedUpdate ()

    {
        if(Time.time>=timetospawn)
        {
            timetospawn = Time.time + timebetweenwaves; 
            SpawnBlocks();
        }
	}
}