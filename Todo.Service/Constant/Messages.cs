using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Todo.Service.Constant
{
    public static class Messages
    {
        public const string TodoAddedMessage = "ToDo Eklendi";
        public const string TodoUpdatedMessage = "ToDo Güncellendi";
        public const string TodoDeletedMessage = "ToDo Silindi.";
        public static string TodoIsNotPresentMessage(Guid id)
        {
            return $"İlgili ID ye göre ToDo bulunamadı : {id}";
        }
    }
}