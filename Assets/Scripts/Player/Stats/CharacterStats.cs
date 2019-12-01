using UnityEngine;

public class CharacterStats : MonoBehaviour
{
    public int MaxHealth;
    public int currentHealth;
    public PlayerManager player;
    private void Start()
    {
        player = SceneManager.Instance.GetPlayerManager();
        currentHealth = player.GetHealth();
        MaxHealth = player.GetMaxHealth();
    }

    public void changeHealth(int _value)
    {

        _value = Mathf.Clamp(_value, 0, int.MaxValue);
        MaxHealth += _value;
        Debug.Log("Health + 5");
    }

    private void Update()
    {

        if (Input.GetKeyDown(KeyCode.T))
        {
            changeHealth(5);
        }
    }
}
