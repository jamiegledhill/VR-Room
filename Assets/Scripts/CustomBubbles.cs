using UnityEngine;

public class CustomBubbles : MonoBehaviour
{    [Tooltip("The object that will be spawned")]
    public GameObject prefab = null;
    [Tooltip("The transform where the object is spawned")]
    public Transform spawnPosition = null;
    public void Spawn()
    {
        GameObject newObject = Instantiate(prefab, spawnPosition.position, spawnPosition.rotation);
        newObject.transform.rotation = Random.rotation;
        float launchSpeed = Random.Range(0.5f, 1.5f);
        Vector3 force = spawnPosition.forward * launchSpeed;
        newObject.GetComponent<Rigidbody>().AddForce(force);
        newObject.GetComponent<Rigidbody>().AddTorque(new Vector3(Random.Range(-1f, 1f),Random.Range(-1f, 1f), Random.Range(-1f, 1f)));
    }
}
