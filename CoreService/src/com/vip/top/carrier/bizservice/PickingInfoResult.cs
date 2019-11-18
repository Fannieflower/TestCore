using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.top.carrier.bizservice{
	
	
	
	
	
	public class PickingInfoResult {
		
		///<summary>
		/// 批次号
		///</summary>
		
		private string batchNo_;
		
		///<summary>
		/// 分拣码
		///</summary>
		
		private string pickCode_;
		
		///<summary>
		/// 承运商信息
		///</summary>
		
		private string carriersCode_;
		
		public string GetBatchNo(){
			return this.batchNo_;
		}
		
		public void SetBatchNo(string value){
			this.batchNo_ = value;
		}
		public string GetPickCode(){
			return this.pickCode_;
		}
		
		public void SetPickCode(string value){
			this.pickCode_ = value;
		}
		public string GetCarriersCode(){
			return this.carriersCode_;
		}
		
		public void SetCarriersCode(string value){
			this.carriersCode_ = value;
		}
		
	}
	
}