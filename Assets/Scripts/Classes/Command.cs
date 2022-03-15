using UnityEngine;

namespace Nature
{
    public class Command : ICommand
    {
        CommandData m_cmdData;
        public Command(CommandData a_cmdData)
        {
            m_cmdData = a_cmdData;
        }
        public void Execute()
        {
            string l_colorHex = Utility.GetRGBAColorHexWithHash(m_cmdData.Color);
            Debug.Log($"<color={l_colorHex}>Command {m_cmdData.ID} executed</color>");
        }
        public void Undo()
        {
            string l_colorHex = Utility.GetRGBAColorHexWithHash(m_cmdData.Color);
            Debug.Log($"<color={l_colorHex}>Undo Command {m_cmdData.ID} executed</color>");
        }
    }
}   
