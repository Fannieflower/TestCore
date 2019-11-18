using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.pms.data.service{
	
	
	
	
	
	public class OrderCouponRequest {
		
		///<summary>
		/// 优惠券编号
		///</summary>
		
		private string couponSn_;
		
		///<summary>
		/// 订单号
		///</summary>
		
		private string orderNo_;
		
		///<summary>
		/// 供应商编号
		///</summary>
		
		private string supplierNo_;
		
		///<summary>
		/// 用户id
		///</summary>
		
		private string userId_;
		
		public string GetCouponSn(){
			return this.couponSn_;
		}
		
		public void SetCouponSn(string value){
			this.couponSn_ = value;
		}
		public string GetOrderNo(){
			return this.orderNo_;
		}
		
		public void SetOrderNo(string value){
			this.orderNo_ = value;
		}
		public string GetSupplierNo(){
			return this.supplierNo_;
		}
		
		public void SetSupplierNo(string value){
			this.supplierNo_ = value;
		}
		public string GetUserId(){
			return this.userId_;
		}
		
		public void SetUserId(string value){
			this.userId_ = value;
		}
		
	}
	
}