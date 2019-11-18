using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.fcs.vei.service{
	
	
	
	
	
	public class GetTrusteeshipInfoRequestModel {
		
		///<summary>
		/// 店铺来源（1为MP）
		///</summary>
		
		private byte? storeSource_;
		
		///<summary>
		/// 店铺ID
		///</summary>
		
		private string storeId_;
		
		///<summary>
		/// 纳税人识别号等
		///</summary>
		
		private string taxRegisterNo_;
		
		public byte? GetStoreSource(){
			return this.storeSource_;
		}
		
		public void SetStoreSource(byte? value){
			this.storeSource_ = value;
		}
		public string GetStoreId(){
			return this.storeId_;
		}
		
		public void SetStoreId(string value){
			this.storeId_ = value;
		}
		public string GetTaxRegisterNo(){
			return this.taxRegisterNo_;
		}
		
		public void SetTaxRegisterNo(string value){
			this.taxRegisterNo_ = value;
		}
		
	}
	
}