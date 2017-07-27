using UnityEngine;

public class EventCollider : MonoBehaviour
{
    [SerializeField]
    private Color[] colors;

    private Renderer myRenderer;

    // Use this for initialization
    private void Start()
    {
        if (GameEventManager.Instance != null)
        {
            GameEventManager.Instance.onCollisionDetected += CollisionHandler;
        }
        else
        {
            Debug.Log("Couldn't subscribe event");
        }
    }

    private void CollisionHandler()
    {
        Debug.Log(string.Format("Fired from event, received at object [{0}]", name));

        if (colors.Length > 0)
        {
            if (myRenderer == null)
            {
                myRenderer = GetComponent<Renderer>();
            }

            if (myRenderer != null)
            {
                myRenderer.material.color = colors[Random.Range(0, colors.Length)];
            }
        }
    }
}