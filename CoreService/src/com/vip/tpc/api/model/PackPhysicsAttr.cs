using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.tpc.api.model{
	
	
	
	
	
	public class PackPhysicsAttr {
		
		///<summary>
		/// 订单号
		///</summary>
		
		private string orderSn_;
		
		///<summary>
		/// 包裹列表
		///</summary>
		
		private List<com.vip.tpc.api.model.Pack> packs_;
		
		///<summary>
		/// 承运商编码，用来校验与订单表tpc_order的字段carrier_code是否一致，不一致则需要返回提示。
		///</summary>
		
		private string carrierCode_;
		
		public string GetOrderSn(){
			return this.orderSn_;
		}
		
		public void SetOrderSn(string value){
			this.orderSn_ = value;
		}
		public List<com.vip.tpc.api.model.Pack> GetPacks(){
			return this.packs_;
		}
		
		public void SetPacks(List<com.vip.tpc.api.model.Pack> value){
			this.packs_ = value;
		}
		public string GetCarrierCode(){
			return this.carrierCode_;
		}
		
		public void SetCarrierCode(string value){
			this.carrierCode_ = value;
		}
		
	}
	
}