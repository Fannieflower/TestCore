using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.top.carrier.bizservice{
	
	
	
	
	
	public class FetchTransportNosRequestModel {
		
		///<summary>
		/// 系统编码
		///</summary>
		
		private string sysKey_;
		
		///<summary>
		/// 供应商编码
		///</summary>
		
		private string vendorCode_;
		
		///<summary>
		/// 承运商编码
		///</summary>
		
		private string thirdCustCode_;
		
		///<summary>
		/// 数量
		///</summary>
		
		private int? size_;
		
		///<summary>
		/// 订单号
		///</summary>
		
		private string orderSn_;
		
		///<summary>
		/// 包裹序号
		///</summary>
		
		private string boxSeq_;
		
		public string GetSysKey(){
			return this.sysKey_;
		}
		
		public void SetSysKey(string value){
			this.sysKey_ = value;
		}
		public string GetVendorCode(){
			return this.vendorCode_;
		}
		
		public void SetVendorCode(string value){
			this.vendorCode_ = value;
		}
		public string GetThirdCustCode(){
			return this.thirdCustCode_;
		}
		
		public void SetThirdCustCode(string value){
			this.thirdCustCode_ = value;
		}
		public int? GetSize(){
			return this.size_;
		}
		
		public void SetSize(int? value){
			this.size_ = value;
		}
		public string GetOrderSn(){
			return this.orderSn_;
		}
		
		public void SetOrderSn(string value){
			this.orderSn_ = value;
		}
		public string GetBoxSeq(){
			return this.boxSeq_;
		}
		
		public void SetBoxSeq(string value){
			this.boxSeq_ = value;
		}
		
	}
	
}