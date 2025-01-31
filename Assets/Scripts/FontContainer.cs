using UnityEngine;

public class FontContainer : MonoBehaviour
{
    public static FontContainer instance { get; private set; }

    public Sprite[] HealthNumbers = new Sprite[31];
    public Sprite[] DamageNumbers = new Sprite[31];
    public Sprite[] RedGlowNumbers = new Sprite[31];
    public Sprite[] CostNumbers = new Sprite[10];

    private void Awake()
    {
        instance = this;
    }
}
