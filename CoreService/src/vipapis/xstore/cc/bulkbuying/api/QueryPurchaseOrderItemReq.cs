using System;
using System.Collections.Generic;
using System.Text;

namespace vipapis.xstore.cc.bulkbuying.api{
	
	
	
	
	
	public class QueryPurchaseOrderItemReq {
		
		///<summary>
		/// 页码，默认1
		/// @sampleValue page 1
		///</summary>
		
		private int? page_;
		
		///<summary>
		/// 每页记录数，默认20
		/// @sampleValue page_size 20
		///</summary>
		
		private int? page_size_;
		
		///<summary>
		/// 采购单号
		///</summary>
		
		private string purchase_no_;
		
		public int? GetPage(){
			return this.page_;
		}
		
		public void SetPage(int? value){
			this.page_ = value;
		}
		public int? GetPage_size(){
			return this.page_size_;
		}
		
		public void SetPage_size(int? value){
			this.page_size_ = value;
		}
		public string GetPurchase_no(){
			return this.purchase_no_;
		}
		
		public void SetPurchase_no(string value){
			this.purchase_no_ = value;
		}
		
	}
	
}