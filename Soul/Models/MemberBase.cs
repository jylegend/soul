using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
namespace Soul.Models
{
    [Table("MemberBase")]
    public class MemberBase
    {
        private int? id;
        public int? Id
        {
            get { return id; }
            set { id = value; }
        }
    }

}