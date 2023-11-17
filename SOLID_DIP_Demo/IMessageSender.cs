namespace SOLID_DIP_Demo
{
    public interface IMessageSender
    {
        void SendMessage(IPerson person, string message);
    }
}