using UnityEngine;
using UnityEngine.InputSystem;

public class Homeworkfour : MonoBehaviour
{
    private Vector2 vector2;

    public void Move(InputAction.CallbackContext callback)
    {
        if (callback.performed)
            vector2 = callback.ReadValue<Vector2>();
        else if(callback.canceled)
            Debug.Log(vector2 - callback.ReadValue<Vector2>());
    }

    private void Start()
    {
        
    }

    private void Update()
    {
        //if (deslizeAction.pe)
        //{
        //    vector2 = deslizeAction.ReadValue<Vector2>();
        //}
        //else if (deslizeAction.WasReleasedThisFrame())
        //{
        //    vector2 =- deslizeAction.ReadValue<Vector2>();
        //    Debug.Log(vector2);
        //}
    }
}
