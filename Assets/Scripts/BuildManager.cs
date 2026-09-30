using UnityEngine;

public class BuildManager : MonoBehaviour
{
    public static BuildManager instance;

    void Awake()
    {
        instance = this;
    }

    public GameObject TurretPrefab;
    public GameObject MinerPrefab;

    private TowerBlueprint towerToBuild;

    public bool CanBuild { get { return towerToBuild != null; } }

    public void SelectTowerToBuild(TowerBlueprint tower)
    {
        towerToBuild = tower;
    }

    public TowerBlueprint GetTowerToBuild()
    {
        return towerToBuild;
    }
}
