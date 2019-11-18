using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.api.promotion.vis.protcontract.service{
	
	
	
	
	
	public class ProtContractSalesNameParam {
		
		///<summary>
		/// 专场名称
		/// @sampleValue salesNameParam xxx专场
		///</summary>
		
		private string salesNameParam_;
		
		///<summary>
		/// 限制条数
		/// @sampleValue limit 100
		///</summary>
		
		private int? limit_;
		
		///<summary>
		/// 供应商编码
		/// @sampleValue vendorCode 103530
		///</summary>
		
		private int? vendorCode_;
		
		public string GetSalesNameParam(){
			return this.salesNameParam_;
		}
		
		public void SetSalesNameParam(string value){
			this.salesNameParam_ = value;
		}
		public int? GetLimit(){
			return this.limit_;
		}
		
		public void SetLimit(int? value){
			this.limit_ = value;
		}
		public int? GetVendorCode(){
			return this.vendorCode_;
		}
		
		public void SetVendorCode(int? value){
			this.vendorCode_ = value;
		}
		
	}
	
}