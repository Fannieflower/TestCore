using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.pms.data.service{
	
	
	
	
	
	public class FetchOrderRequestModel {
		
		///<summary>
		/// 订单号
		///</summary>
		
		private string orderSn_;
		
		///<summary>
		/// 引用类型：ACTIVITY-活动, COMMAND-口令红包, SPECIAL-专享价, PAYMENT-支付优惠
		///</summary>
		
		private string refType_;
		
		///<summary>
		/// 引用号，相应类型的号码，如活动号、专享价号等
		///</summary>
		
		private string refNo_;
		
		///<summary>
		/// 用户ID，必传
		///</summary>
		
		private long? userId_;
		
		///<summary>
		/// 引用号，相应类型的号码，如活动号、专享价号等集合
		///</summary>
		
		private List<string> refNoList_;
		
		public string GetOrderSn(){
			return this.orderSn_;
		}
		
		public void SetOrderSn(string value){
			this.orderSn_ = value;
		}
		public string GetRefType(){
			return this.refType_;
		}
		
		public void SetRefType(string value){
			this.refType_ = value;
		}
		public string GetRefNo(){
			return this.refNo_;
		}
		
		public void SetRefNo(string value){
			this.refNo_ = value;
		}
		public long? GetUserId(){
			return this.userId_;
		}
		
		public void SetUserId(long? value){
			this.userId_ = value;
		}
		public List<string> GetRefNoList(){
			return this.refNoList_;
		}
		
		public void SetRefNoList(List<string> value){
			this.refNoList_ = value;
		}
		
	}
	
}