using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class hud_bunker_hp : MonoBehaviour
{
    Text text_bunker_hp;
    void Start()
    {
        text_bunker_hp = GameObject.Find("text_bunker_hp").GetComponent<Text>();
    }

    void Update()
    {
        Data.Bunker.HP++;
        if (text_bunker_hp)
            text_bunker_hp.text = "Bunker HP: " + Data.Bunker.HP.ToString();
    }
}
