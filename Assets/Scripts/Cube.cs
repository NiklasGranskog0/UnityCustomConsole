using Console;
using UnityEngine;

public class Cube : MonoBehaviour
{
    private void OnEnable()
    { 
        Log.Message("On Enable", "Second", LogType.Warning);
    }

    private void Awake()
    {
        Log.Message("Awake", "First");
    }

    private void Start()
    {
        TestFunction();
    }

    private void TestFunction()
    {
        Log.Message("TestFunction", "Third", LogType.Error);
        TestFunction2();
    }
    
    private void TestFunction2()
    {
        Log.Message("TestFunction2", "Third", LogType.Error);
        TestFunction3();
    }
    
    private void TestFunction3()
    {
        Log.Message("TestFunction3", "Third", LogType.Error);
        TestFunction4();
    }
    
    private void TestFunction4()
    {
        Log.Message("TestFunction4", "Third", LogType.Error);
        TestFunction5();
    }
    
    private void TestFunction5()
    {
        Log.Message("TestFunction5", "Third", LogType.Error);
    }
}