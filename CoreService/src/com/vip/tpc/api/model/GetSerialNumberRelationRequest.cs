using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.tpc.api.model{
	
	
	
	
	
	public class GetSerialNumberRelationRequest {
		
		///<summary>
		/// 请求头
		///</summary>
		
		private com.vip.tpc.api.model.common.TpcRequestHeader header_;
		
		///<summary>
		/// 承运商编码
		///</summary>
		
		private string shipperCode_;
		
		///<summary>
		/// 承运商单据编码（订单号/客退申请单）
		///</summary>
		
		private string carrierSerialNo_;
		
		///<summary>
		/// 关系类型：1。订单号关系，2。客退申请单关系
		///</summary>
		
		private int? relationType_;
		
		public com.vip.tpc.api.model.common.TpcRequestHeader GetHeader(){
			return this.header_;
		}
		
		public void SetHeader(com.vip.tpc.api.model.common.TpcRequestHeader value){
			this.header_ = value;
		}
		public string GetShipperCode(){
			return this.shipperCode_;
		}
		
		public void SetShipperCode(string value){
			this.shipperCode_ = value;
		}
		public string GetCarrierSerialNo(){
			return this.carrierSerialNo_;
		}
		
		public void SetCarrierSerialNo(string value){
			this.carrierSerialNo_ = value;
		}
		public int? GetRelationType(){
			return this.relationType_;
		}
		
		public void SetRelationType(int? value){
			this.relationType_ = value;
		}
		
	}
	
}