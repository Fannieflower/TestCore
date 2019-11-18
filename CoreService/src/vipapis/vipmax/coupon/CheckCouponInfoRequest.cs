using System;
using System.Collections.Generic;
using System.Text;

namespace vipapis.vipmax.coupon{
	
	
	
	
	
	public class CheckCouponInfoRequest {
		
		///<summary>
		/// 用户加密的openID
		///</summary>
		
		private string open_uid_;
		
		///<summary>
		/// 线下门店对应的仓库编码
		///</summary>
		
		private string warehouse_;
		
		///<summary>
		/// 订单号
		///</summary>
		
		private string order_sn_;
		
		///<summary>
		/// 订单商品信息
		///</summary>
		
		private List<vipapis.vipmax.coupon.OrderSku> order_skus_;
		
		///<summary>
		/// 使用的优惠券信息
		///</summary>
		
		private List<vipapis.vipmax.coupon.CouponInfo> coupon_sns_;
		
		public string GetOpen_uid(){
			return this.open_uid_;
		}
		
		public void SetOpen_uid(string value){
			this.open_uid_ = value;
		}
		public string GetWarehouse(){
			return this.warehouse_;
		}
		
		public void SetWarehouse(string value){
			this.warehouse_ = value;
		}
		public string GetOrder_sn(){
			return this.order_sn_;
		}
		
		public void SetOrder_sn(string value){
			this.order_sn_ = value;
		}
		public List<vipapis.vipmax.coupon.OrderSku> GetOrder_skus(){
			return this.order_skus_;
		}
		
		public void SetOrder_skus(List<vipapis.vipmax.coupon.OrderSku> value){
			this.order_skus_ = value;
		}
		public List<vipapis.vipmax.coupon.CouponInfo> GetCoupon_sns(){
			return this.coupon_sns_;
		}
		
		public void SetCoupon_sns(List<vipapis.vipmax.coupon.CouponInfo> value){
			this.coupon_sns_ = value;
		}
		
	}
	
}