using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.venus.visPo.service{
	
	
	
	
	
	public class PoHeaderInfo {
		
		///<summary>
		/// id标识
		///</summary>
		
		private string id_;
		
		///<summary>
		/// po采购单号
		///</summary>
		
		private string poNo_;
		
		///<summary>
		/// 供应商编码
		///</summary>
		
		private string vendorCode_;
		
		///<summary>
		/// po类型
		///</summary>
		
		private string purchaseType_;
		
		public string GetId(){
			return this.id_;
		}
		
		public void SetId(string value){
			this.id_ = value;
		}
		public string GetPoNo(){
			return this.poNo_;
		}
		
		public void SetPoNo(string value){
			this.poNo_ = value;
		}
		public string GetVendorCode(){
			return this.vendorCode_;
		}
		
		public void SetVendorCode(string value){
			this.vendorCode_ = value;
		}
		public string GetPurchaseType(){
			return this.purchaseType_;
		}
		
		public void SetPurchaseType(string value){
			this.purchaseType_ = value;
		}
		
	}
	
}