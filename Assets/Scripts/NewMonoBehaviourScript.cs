using UnityEngine;
using UnityEngine.InputSystem;

public class NewMonoBehaviourScript : MonoBehaviour
{
    [SerializeField] private float moveSpeed;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("Start is Called");
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 inputVector = new Vector3(0, 0, 0);
        if (Keyboard.current.wKey.isPressed)
        {
            inputVector.z = 1;
        }
        if (Keyboard.current.sKey.isPressed)
        {
            inputVector.z = - 1;
        }
        if (Keyboard.current.aKey.isPressed)
        {
            inputVector.x = - 1;
        }
        if (Keyboard.current.dKey.isPressed)
        {
            inputVector.x = 1;
        }
        transform.position += inputVector.normalized * Time.deltaTime * moveSpeed;
        Debug.Log("Updated is Called");
    }
}
