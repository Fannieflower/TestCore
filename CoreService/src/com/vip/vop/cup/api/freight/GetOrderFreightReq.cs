using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.vop.cup.api.freight{
	
	
	
	
	
	public class GetOrderFreightReq {
		
		///<summary>
		/// 用于区分一整批请求的唯一主键，用于在返回结果中获取订单和运费的映射关系
		///</summary>
		
		private string key_;
		
		///<summary>
		/// 订单金额
		///</summary>
		
		private double? order_amount_;
		
		public string GetKey(){
			return this.key_;
		}
		
		public void SetKey(string value){
			this.key_ = value;
		}
		public double? GetOrder_amount(){
			return this.order_amount_;
		}
		
		public void SetOrder_amount(double? value){
			this.order_amount_ = value;
		}
		
	}
	
}