using System;
using System.Collections.Generic;
using System.Text;

namespace vipapis.marketplace.invoice{
	
	
	
	
	
	public class GetInvoicesResponse {
		
		///<summary>
		/// 发票信息列表
		///</summary>
		
		private List<vipapis.marketplace.invoice.Invoice> invoices_;
		
		///<summary>
		/// 是否有下一页
		///</summary>
		
		private bool? has_next_;
		
		public List<vipapis.marketplace.invoice.Invoice> GetInvoices(){
			return this.invoices_;
		}
		
		public void SetInvoices(List<vipapis.marketplace.invoice.Invoice> value){
			this.invoices_ = value;
		}
		public bool? GetHas_next(){
			return this.has_next_;
		}
		
		public void SetHas_next(bool? value){
			this.has_next_ = value;
		}
		
	}
	
}