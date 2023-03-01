using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiWhatsAppClone.Models
{
    public record ChatModel(string Avatar, string Name, DateTime LastMessageAt, string LastMessage, int UnreadCount)
    {
        public string LastMessageAtDisplay => $"{LastMessageAt:hh:mm}";
    }
}
