
using UnityEngine;
using UnityEngine.InputSystem;

public class MovimientoFlechas : MonoBehaviour
{
    public float velocidad = 5f;

    private InputAction movimiento;

    void OnEnable()
    {
        movimiento = new InputAction(
            "MoveFlechas",
            InputActionType.Value
        );

        movimiento.AddCompositeBinding("2DVector")
            .With("Up", "<Keyboard>/upArrow")
            .With("Down", "<Keyboard>/downArrow")
            .With("Left", "<Keyboard>/leftArrow")
            .With("Right", "<Keyboard>/rightArrow");

        movimiento.Enable();
    }

    void Update()
    {
        Vector2 direccion = movimiento.ReadValue<Vector2>();

        // Evitar movimiento diagonal
        if (Mathf.Abs(direccion.x) > 0)
            direccion.y = 0;

        transform.Translate(
            direccion * velocidad * Time.deltaTime
        );
    }

    void OnDisable()
    {
        movimiento.Disable();
        movimiento.Dispose();
    }
}
