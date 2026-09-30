using UnityEngine;

public class Shop : MonoBehaviour 
{
    public TowerBlueprint turret;
    public TowerBlueprint miner;
    public TowerBlueprint mountain;
    
    BuildManager buildManager;

    void Start()
    {
        buildManager = BuildManager.instance;
    }

    public void SelectTurret()
    {
        Debug.Log("Turret selected!");
        buildManager.SelectTowerToBuild(turret);
    }

    public void SelectMiner()
    {
        Debug.Log("Miner selected!");
        buildManager.SelectTowerToBuild(miner);
    }

    public void SelectTerraform()
    {
        Debug.Log("Terraforming selected!");
        buildManager.SelectTowerToBuild(mountain);
    }
}
