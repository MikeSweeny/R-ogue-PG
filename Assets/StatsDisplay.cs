using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StatsDisplay : MonoBehaviour
{
    PlayerManager player;

    public Text UIbones;
    public Text UIlifesteal;
    public Text UIattackCD;
    public Text UIdefense;
    private void Start()
    {
        player = SceneManager.Instance.GetPlayerManager();
    }

    private void Update()
    {
        UIdefense.text = player.GetDefense().ToString();
        UIlifesteal.text = player.GetLifestealPercent().ToString() + "%";
        UIattackCD.text = player.GetAttackCD().ToString();
        UIbones.text = player.GetBones().ToString();
    }
}
