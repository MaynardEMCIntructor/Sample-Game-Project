using UnityEngine;

public class SampleScripts : MonoBehaviour
{
    public string playerName = "Maynard";
    public int healthPoints = 100;
    public float damageOutput = 50.5f;
    public string[] gender = { "Male", "Female", "Undefine"};

    private void Start()
    {
        Debug.Log("playerName: " + playerName);
        Debug.Log("HealthPoints: " + healthPoints);
        print("DamageOutput: " + damageOutput);
        print("Gender: " + gender[3]);

        Debug.Log("Hello World");
    }
}
