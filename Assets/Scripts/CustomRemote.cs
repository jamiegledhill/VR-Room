using UnityEngine;

public class CustomRemote : MonoBehaviour
{
    [Tooltip("The object that will be spawned")]
    public GameObject prefab = null;
    [Tooltip("The transform where the object is spanwed")]
    public Transform spawnPosition = null;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    public void Spawn()
    {
        Instantiate(prefab, spawnPosition.position, spawnPosition.rotation);
    }
}
