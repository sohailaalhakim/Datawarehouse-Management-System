using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Entities
{
	public class Product
	{
		public int ID { get; set; }
		public string Name { get; set; }
		public string Code { get; set; }
        public int Quantity { get; set; }
        public string Notes { get; set; }
        public decimal Price { get; set; }
        public DateTime ProductionDate { get; set; }
        public DateTime Expirydate { get; set; }

        public string UnitsOfPriMeasure { get; set; }
		public virtual Store Store { get; set; }
		public virtual ImportPermit ImportPermit { get; set; }
        public virtual ICollection<ImportPermitDetails> ImportPermitDetails { get; set; }
        public virtual ICollection<ExchangePermitDetails> ExchangePermitDetails { get; set; }

    }
}
