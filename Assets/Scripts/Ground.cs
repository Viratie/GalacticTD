using UnityEngine;
using UnityEngine.EventSystems;

[RequireComponent(typeof(Renderer))]
public class Ground : MonoBehaviour
{
    public Color hoverColor;    
    public Vector3 positionOffset;

    [Header("Optional")]
    public GameObject tower;

    private Color startColor;
    private Renderer rend;

    BuildManager buildManager;

    void Start()
    {
        if (tower != null)
        {
            Instantiate(tower, GetBuildPosition(), Quaternion.identity);
        }

        rend = GetComponent<Renderer>();
        startColor = rend.material.color;

        buildManager = BuildManager.instance;
    }

    void BuildTurret(TowerBlueprint blueprint)
    {
        if (PlayerStats.Money < blueprint.cost)
        {
            Debug.Log("Not enough Money!");
            return;
        }

        PlayerStats.Money -= blueprint.cost;
        
        GameObject _tower = (GameObject)Instantiate(blueprint.prefab, GetBuildPosition(), Quaternion.identity);
        tower = _tower;

        Debug.Log("Build, Money left:" + PlayerStats.Money);
    }

    void OnMouseDown()
    {
        if (EventSystem.current.IsPointerOverGameObject())
            return;

        if (!buildManager.CanBuild)
            return;
            

        if (tower != null)
        {
            Debug.Log ("Can't build there!");
            return;
        }

        BuildTurret(buildManager.GetTowerToBuild());
    }

    public Vector3 GetBuildPosition()
    {
        return transform.position + positionOffset;
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void OnMouseEnter() 
    {
        if (EventSystem.current.IsPointerOverGameObject())
            return;

        if (!buildManager.CanBuild)
            return;

        rend.material.color = hoverColor;
    }

    void OnMouseExit()
    {
        rend.material.color = startColor;
    }
}
