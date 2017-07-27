using UnityEngine;

public class DelegateHandler : MonoBehaviour
{
    [SerializeField]
    private GameObject[] objectsToDestroy;

    // Use this for initialization
    private void Start()
    {        
        GameDelegateManager.Instance.onDistanceMoved += OnDistanceCompleted;
    }

    private void OnDistanceCompleted()
    {
        Debug.Log("Called by delegate");

        if (objectsToDestroy.Length > 0)
        {
            for (int i = 0; i < objectsToDestroy.Length; i++)
            {
                GameObject currentObject = objectsToDestroy[i];

                if (currentObject != null)
                {
                    Destroy(currentObject);
                }
            }
        }
    }

    // Update is called once per frame
    private void Update()
    {
    }
}