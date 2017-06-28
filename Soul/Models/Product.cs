using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Soul.Models
{
    [Table("Product")]
    public class Product
    {
        private int? id;

        /// <summary>
        /// 主键id
        /// </summary>
        public int? Id
        {
            get { return id; }
            set { id = value; }
        }

        private string name;

        /// <summary>
        /// 名称
        /// </summary>
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private string ename;

        /// <summary>
        /// 英文名
        /// </summary>
        public string Ename
        {
            get { return ename; }
            set { ename = value; }
        }

        private double? vipPrice;

        /// <summary>
        /// vip价格
        /// </summary>
        public double? VipPrice
        {
            get { return vipPrice; }
            set { vipPrice = value; }
        }

        private double? currentPrice;

        /// <summary>
        /// 当前价格
        /// </summary>
        public double? CurrentPrice
        {
            get { return currentPrice; }
            set { currentPrice = value; }
        }
        
    }
}