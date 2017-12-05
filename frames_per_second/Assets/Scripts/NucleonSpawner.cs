using UnityEngine;

public class NucleonSpawner : MonoBehaviour {

	public float timeBetweenSpawns;
	public float spawnDistance;
	public float timeSinceLastSpawn;
	public Nucleon[] nucleonPrefabs;

	void SpawnNucleon() {
		Nucleon prefab = nucleonPrefabs [Random.Range (0, nucleonPrefabs.Length)];
		Nucleon spawn = Instantiate<Nucleon>(prefab);
		spawn.transform.localPosition = Random.onUnitSphere * spawnDistance;
	}



	void FixedUpdate() {
		timeSinceLastSpawn += Time.deltaTime;
		if (timeSinceLastSpawn >= timeBetweenSpawns) {
			timeSinceLastSpawn -= timeBetweenSpawns;
			SpawnNucleon();
		}
	}
}
