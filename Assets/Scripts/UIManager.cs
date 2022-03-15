using UnityEngine;
using UnityEngine.UI;

namespace Nature
{
    public class UIManager : MonoBehaviour
    {
        [SerializeField] Button m_btnExecuteCmd;
        [SerializeField] Button m_btnUndoCmd;
        void Start()
        {
            m_btnExecuteCmd.onClick.AddListener(() => ExecuteCommand());
            m_btnUndoCmd.onClick.AddListener(() => UndoCommand());
        }
        void ExecuteCommand()
        {
            Command l_command = new Command( GetUniqueCommand());
            CommandsManager.ExecuteCommand(l_command);
        }
        void UndoCommand()
        {
            CommandsManager.Undo();
        }
        CommandData GetUniqueCommand()
        {
            return new CommandData(Utility.GetUniqueID(), Random.ColorHSV()); ;
        }
    }
}   
