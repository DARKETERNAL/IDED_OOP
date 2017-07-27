using UnityEngine;

public class BasicCharacterController : MonoBehaviour
{
    [SerializeField]
    private float walkSpeed = 50F;

    [SerializeField]
    private float rotateSpeed = 50F;

    [SerializeField]
    private float jumpForce = 10F;

    // Use this for initialization
    private void Start()
    {
    }

    // Update is called once per frame
    private void Update()
    {
        float verticalVal = Input.GetAxis("Vertical");

        if (verticalVal != 0F)
        {            
            transform.Translate(transform.forward * (verticalVal * walkSpeed * Time.deltaTime), Space.World);
        }

        float horizontalVal = Input.GetAxis("Horizontal");

        if (horizontalVal != 0F)
        {
            transform.Rotate(new Vector3(0F, horizontalVal * rotateSpeed * Time.deltaTime, 0F));
        }
    }
}