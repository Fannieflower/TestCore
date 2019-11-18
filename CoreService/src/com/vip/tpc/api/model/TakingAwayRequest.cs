using System;
using System.Collections.Generic;
using System.Text;
using vipapis_S = vipapis;

namespace com.vip.tpc.api.model{
	
	
	
	
	
	public class TakingAwayRequest {
		
		///<summary>
		/// 订单号
		///</summary>
		
		private string orderSn_;
		
		///<summary>
		/// 揽收类型
		///</summary>
		
		private string type_;
		
		///<summary>
		/// 包裹列表
		///</summary>
		
		private List<vipapis_S.tpc.service.Pack> packs_;
		
		public string GetOrderSn(){
			return this.orderSn_;
		}
		
		public void SetOrderSn(string value){
			this.orderSn_ = value;
		}
		public string GetType(){
			return this.type_;
		}
		
		public void SetType(string value){
			this.type_ = value;
		}
		public List<vipapis_S.tpc.service.Pack> GetPacks(){
			return this.packs_;
		}
		
		public void SetPacks(List<vipapis_S.tpc.service.Pack> value){
			this.packs_ = value;
		}
		
	}
	
}