using UnityEngine;

public class SpawnBricks : MonoBehaviour
{
    public GameObject brickPrefab;
    public GameObject parentSpawnBrickGo;

    public float spawnRate = 3f;
    public float nextSpawn = 4f;

    void Start()
    {
        SpawnThePresents();
    }

    void Update()
    {
        if (Time.time > nextSpawn)
        {
            nextSpawn = Time.time + spawnRate;
            SpawnThePresents();
        }
    }
    private void SpawnThePresents()
    {
        var clones = Instantiate(brickPrefab);
        clones.GetComponent<Transform>().SetParent(parentSpawnBrickGo.GetComponent<Transform>(), false);
        clones.GetComponent<Transform>().localPosition = new Vector3(Random.Range(-400, 400), 0, 0);
        clones.GetComponent<Transform>().localRotation = Quaternion.identity;
        clones.GetComponent<Transform>().localScale = new Vector3(0.5f, 0.5f, 0.5f);
    }
}
