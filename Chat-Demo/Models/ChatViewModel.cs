﻿namespace Chat_Demo.Models
{
    public class ChatViewModel
    {
        public ChatViewModel()
        {
            this.Messages = new HashSet<MessageViewModel>();
        }
        public MessageViewModel CurrentMessage { get; set; } = null!;
        public ICollection<MessageViewModel> Messages { get; set; }
    }
}
