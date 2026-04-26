using UnityEngine;

public class CameraSwitcher : MonoBehaviour
{
    public GameObject mainCamera;
    public GameObject driverCamera;

    void Start()
    {
        mainCamera.SetActive(true);
        driverCamera.SetActive(false);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            mainCamera.SetActive(!mainCamera.activeSelf);
            driverCamera.SetActive(!driverCamera.activeSelf);
        }
    }
}