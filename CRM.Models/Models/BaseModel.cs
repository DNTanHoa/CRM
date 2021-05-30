using System;
using System.Collections.Generic;
using System.Text;

namespace CRM.Models
{
    public class BaseModel
    {
        public User CreateBy { get; set; }
        public DateTime? CreateDate { get; set; }
        public User UpdateBy { get; set; }
        public DateTime? UpdateDate { get; set; }
    }
}
