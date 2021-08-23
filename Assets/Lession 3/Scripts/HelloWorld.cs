using UnityEngine;

public class HelloWorld : MonoBehaviour
{
    public string myName = "Hải";
    // Start is called before the first frame update

    private void Awake()
    {
        print("Awake");
    }

    private void OnEnable()
    {
        print("OnEnable");
    }

    void Start()
    {
        print("HelloWorld");   
        
        Debug.Log("HelloWorld");
        
        Debug.LogWarning("HelloWorld");
        
        Debug.LogError("HelloWorld");
        
        Debug.LogFormat("HelloWorld {0}", myName);
    }

    private void Update()
    {
        print("Update");
    }

    private void FixedUpdate()
    {
        print("FixedUpdate");
    }

    private void LateUpdate()
    {
        print("LateUpdate");
    }

    private void OnDisable()
    {
        print("OnDisable");
    }

    private void OnDestroy()
    {
        print("OnDestroy");
    }
}
