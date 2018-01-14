using UnityEngine;

public class BuildManager : MonoBehaviour {

    public static BuildManager instance;
    
    //nambahin turet
    void Awake()
    {
        if(instance != null)
        {
            Debug.LogError("More than one Buildmanager in scene");
            return;
        }
        instance = this;
    }

    public GameObject turet1;
    public GameObject turet2;

    public NodeUI nodeUI;

    public GameObject buildEffect;
    public GameObject sellEffect;

    private TurretBlueprint turretToBuild;
    private Node selectNode;

    public bool CanBuild { get { return turretToBuild != null;} }
    public bool HasMoney { get { return PlayerStats.Money >= turretToBuild.cost; } }

    public void SelectNode(Node node)
    {
        if(selectNode == node)
        {
            DeselectNode();
            return;
        }

        selectNode = node;
        turretToBuild = null;

        nodeUI.SetTarget(node);
    }

    public void DeselectNode()
    {
        selectNode = null;
        nodeUI.Hide();
    }

    public void SelectTurretToBuild(TurretBlueprint turret)
    {
        turretToBuild = turret;
        DeselectNode();
    }

    public TurretBlueprint GetTurretToBuild()
    {
        return turretToBuild;
    }
}
