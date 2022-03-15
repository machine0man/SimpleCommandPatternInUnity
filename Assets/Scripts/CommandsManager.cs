using System.Collections.Generic;
using UnityEngine;

namespace Nature
{
    public class CommandsManager : MonoBehaviour
    {
        static CommandsManager s_Instance;
        Stack<ICommand> m_stkCommands = new Stack<ICommand>();

        #region Unity Methods
        private void Awake()
        {
            s_Instance = this;
        }
        private void OnDestroy()
        {
            s_Instance = null;
        }
        #endregion

        #region Static Methods
        public static void ExecuteCommand(ICommand a_cmd)
        {
            s_Instance.ExecuteCommand_internal(a_cmd);
        }
        public static void Undo()
        {
            s_Instance.Undo_internal();
        } 
        #endregion

        void ExecuteCommand_internal(ICommand a_cmd)
        {
            a_cmd.Execute();
            m_stkCommands.Push(a_cmd);
        }
        void Undo_internal()
        {
            if (m_stkCommands.Count == 0)
            {
                Debug.Log($"Nothing to Undo More!");
                return;
            }
            ICommand l_lastCommand = m_stkCommands.Pop();
            l_lastCommand.Undo();
        }
    }
}   
