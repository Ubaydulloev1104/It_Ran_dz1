﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_2_1
{
    public class Menu
    {
        public string Name { get; set; }
        public Menu[] Childs;
        public Menu(string menuName)
        {
            Name = menuName;
        }
        public Menu(string menuName, Menu[] childs)
        {
            Name = menuName;
            Childs = childs;
        }
        public string Generate()
        {
            string result = $"<li>{Name}</li>";

            if (Childs != null && Childs.Length > 0)
            {
                result += "<ul>";

                foreach (Menu child in Childs)
                {
                    result += child.Generate();
                }

                result += "</ul>";
            }

            return result;
        }
    }
}
