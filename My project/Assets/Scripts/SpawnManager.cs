using UnityEngine;
using UnityEngine.InputSystem;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    public InputAction spawnAction;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        spawnAction.Enable();
    }

    // Update is called once per frame
    void Update()
    {
        if(spawnAction.triggered)
        {
            Instantiate(animalPrefabs[0], new Vector3(0, 0, 20), animalPrefabs[0].transform.rotation);
        }
    }
}
