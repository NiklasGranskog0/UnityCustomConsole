using Console;
using UnityEngine;

public class Cube : MonoBehaviour
{
    private void OnEnable()
    {
        Log.Message("On Enable", "Second", LogType.Warning);
        Debug.Log("On Enable");
    }

    private void Awake()
    {
        Log.Message("Awake", "First");
        Debug.Log("Awake");
    }

    private void Start()
    {
        TestFunction();
    }

    private void TestFunction()
    {
        Log.Message("Start", "Third", LogType.Error);
    }
}