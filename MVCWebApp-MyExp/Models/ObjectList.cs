using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCWebApp_MyExp.Models
{
    public class ObjectList
    {
        public List<ObjectItem> ObjList { get; set; }

        public ObjectList()
        {
            ObjList = new List<ObjectItem>();
        }
    }
 }