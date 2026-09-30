using UnityEngine;

public class Miner : MonoBehaviour
{
    public float minerMoneyCountdown;
    public int moneyGivenByMiner;

    public GameObject minerShot;

    private float countdown;

    // Update is called once per frame
    void Update()
    {
        if (countdown <= 0f)
        {
            GameObject effectIns = (GameObject)Instantiate(minerShot, transform.position, Quaternion.identity);
            Destroy(effectIns, 2f);

            PlayerStats.Money += moneyGivenByMiner;
            countdown = minerMoneyCountdown;
        }

        countdown -= Time.deltaTime;
    }
}
