using UnityEngine;
using UnityEngine.UI;

public class StatDisplayer : MonoBehaviour
{
    public PlayerStat manager;
    public Text hp;
    public Text armor;
    public Text dmg;
    public Text fr;
    public Text ms;
    public Text skill;

    // Start is called before the first frame update
    void Start()
    {
        manager = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerStat>();
    }

    // Update is called once per frame
    void Update()
    {
        hp.text = "Health: " + manager.health.GetValue().ToString();
        armor.text = "Armor: " + manager.armor.GetValue().ToString();
        dmg.text = "Damage: " + manager.damage.GetValue().ToString();
        fr.text = "Fire Rate: " + manager.fireRate.GetValue().ToString();
        ms.text = "Movement speed: " + manager.movenentSpeed.GetValue().ToString();
    }
}
