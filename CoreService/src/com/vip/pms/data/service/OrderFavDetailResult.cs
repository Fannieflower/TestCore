using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.pms.data.service{
	
	
	
	
	
	public class OrderFavDetailResult {
		
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
		/// 商品优惠分摊明细
		///</summary>
		
		private List<com.vip.pms.data.service.OrderFavDetail> orderFavDetails_;
		
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
		public List<com.vip.pms.data.service.OrderFavDetail> GetOrderFavDetails(){
			return this.orderFavDetails_;
		}
		
		public void SetOrderFavDetails(List<com.vip.pms.data.service.OrderFavDetail> value){
			this.orderFavDetails_ = value;
		}
		
	}
	
}