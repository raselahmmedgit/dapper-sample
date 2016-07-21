namespace DapperORM.Core.Entities
{
    public enum MessageType
    {
        None = 1,
        Success = 2,
        Error = 3,
        Information = 4,
        Warning = 5,
    }

    public class Message
    {
        public Message()
        {
            MessageType = MessageType.None;
        }
        public MessageType MessageType { get; set; }
        public string CurrentMessage { get; set; }

    }

    public static class SetMessage
    {
        public static Message SetSuccessMessage(string currentMessage = "Success !")
        {
            return new Message {MessageType = MessageType.Success, CurrentMessage = currentMessage};
        }
        public static Message SetErrorMessage(string currentMessage = "Error !")
        {
            return new Message { MessageType = MessageType.Error, CurrentMessage = currentMessage };
        }
        public static Message SetInformationMessage(string currentMessage = "Information !")
        {
            return new Message { MessageType = MessageType.Information, CurrentMessage = currentMessage };
        }
        public static Message SetWarningMessage(string currentMessage = "Warning !")
        {
            return new Message { MessageType = MessageType.Warning, CurrentMessage = currentMessage };
        }
    }
}
