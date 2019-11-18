using System;
using System.Collections.Generic;
using System.Text;

namespace vipapis.vipmax.order{
	
	
	
	
	
	public class SyncOrderRequest {
		
		///<summary>
		/// 商家订单号
		///</summary>
		
		private string out_order_sn_;
		
		///<summary>
		/// 用户支付时间，相当于订单完成时间
		///</summary>
		
		private System.DateTime? pay_time_;
		
		///<summary>
		/// 产生销售的仓库编号
		///</summary>
		
		private string sales_warehouse_;
		
		///<summary>
		/// 用户加密的openID
		///</summary>
		
		private string open_uid_;
		
		///<summary>
		/// 用户手机号
		///</summary>
		
		private string mobile_;
		
		///<summary>
		/// 订单明细
		///</summary>
		
		private List<vipapis.vipmax.order.VipmaxOrderDetail> order_detail_;
		
		///<summary>
		/// 优惠前的订单总金额
		///</summary>
		
		private double? total_fee_;
		
		///<summary>
		/// 总优惠金额
		///</summary>
		
		private double? discount_fee_;
		
		///<summary>
		/// 客户应付金额（客户应付金额=订单总金额-总优惠金额）
		///</summary>
		
		private double? payable_fee_;
		
		///<summary>
		/// 公司代码:xstorebuy，maxxbuy
		///</summary>
		
		private string company_code_;
		
		public string GetOut_order_sn(){
			return this.out_order_sn_;
		}
		
		public void SetOut_order_sn(string value){
			this.out_order_sn_ = value;
		}
		public System.DateTime? GetPay_time(){
			return this.pay_time_;
		}
		
		public void SetPay_time(System.DateTime? value){
			this.pay_time_ = value;
		}
		public string GetSales_warehouse(){
			return this.sales_warehouse_;
		}
		
		public void SetSales_warehouse(string value){
			this.sales_warehouse_ = value;
		}
		public string GetOpen_uid(){
			return this.open_uid_;
		}
		
		public void SetOpen_uid(string value){
			this.open_uid_ = value;
		}
		public string GetMobile(){
			return this.mobile_;
		}
		
		public void SetMobile(string value){
			this.mobile_ = value;
		}
		public List<vipapis.vipmax.order.VipmaxOrderDetail> GetOrder_detail(){
			return this.order_detail_;
		}
		
		public void SetOrder_detail(List<vipapis.vipmax.order.VipmaxOrderDetail> value){
			this.order_detail_ = value;
		}
		public double? GetTotal_fee(){
			return this.total_fee_;
		}
		
		public void SetTotal_fee(double? value){
			this.total_fee_ = value;
		}
		public double? GetDiscount_fee(){
			return this.discount_fee_;
		}
		
		public void SetDiscount_fee(double? value){
			this.discount_fee_ = value;
		}
		public double? GetPayable_fee(){
			return this.payable_fee_;
		}
		
		public void SetPayable_fee(double? value){
			this.payable_fee_ = value;
		}
		public string GetCompany_code(){
			return this.company_code_;
		}
		
		public void SetCompany_code(string value){
			this.company_code_ = value;
		}
		
	}
	
}