using UnityEngine;

public class CameraSwitcher : MonoBehaviour
{
    // --- Player 1 Variables ---
    public Camera mainCamera1;
    public Camera driverCamera1;
    public KeyCode switchKey1 = KeyCode.C;

    // --- Player 2 Variables ---
    public Camera mainCamera2;
    public Camera driverCamera2;
    public KeyCode switchKey2 = KeyCode.M;

    void Start()
    {
        // Force the game to start with only the Main Cameras active
        mainCamera1.enabled = true;
        driverCamera1.enabled = false;

        mainCamera2.enabled = true;
        driverCamera2.enabled = false;
    }

    void Update()
    {
        // Player 1 Camera Toggle
        if (Input.GetKeyDown(switchKey1))
        {
            mainCamera1.enabled = !mainCamera1.enabled;
            driverCamera1.enabled = !driverCamera1.enabled;
        }

        // Player 2 Camera Toggle
        if (Input.GetKeyDown(switchKey2))
        {
            mainCamera2.enabled = !mainCamera2.enabled;
            driverCamera2.enabled = !driverCamera2.enabled;
        }
    }
}