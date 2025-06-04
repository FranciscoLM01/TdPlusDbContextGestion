using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TdPlusDbContextGestion.Domain.Common;

namespace TdPlusDbContextGestion.Domain.Entities {
	public class ValorUDIBanxico : BaseEntity {

		public int Id { get; set; }
		public DateTime dFecha { get; set; }
		public decimal nValor { get; set; }

	}
}
