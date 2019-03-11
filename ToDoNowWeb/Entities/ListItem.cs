using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ToDoNowWeb.Entities
{
    public class ListItem
    {
        public int Id { get; set; }

        public string ItemText { get; private set; }

        public ListItem(string itemText)
        {
            if(string.IsNullOrEmpty(itemText))
            {
                throw new ArgumentNullException(nameof(itemText));
            }

            ItemText = itemText;
        }
  
    }

}