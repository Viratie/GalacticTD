using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    public static int Money;
    public int startMoney = 50;

    public static int Lives;
    public int startLives = 3;

    void Start()
    {
        Money = startMoney;
        Lives = startLives;
    }
}
