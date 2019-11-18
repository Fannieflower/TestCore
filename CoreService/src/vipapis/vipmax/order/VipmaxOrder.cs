using System;
using System.Collections.Generic;
using System.Text;

namespace vipapis.vipmax.order{
	
	
	
	
	
	public class VipmaxOrder {
		
		///<summary>
		/// 商家订单号
		///</summary>
		
		private string out_order_sn_;
		
		///<summary>
		/// 用户支付时间，相当于订单完成时间
		///</summary>
		
		private System.DateTime? pay_time_;
		
		///<summary>
		/// 产生销售的仓库信息
		///</summary>
		
		private vipapis.vipmax.order.WarehouseInfo sales_warehouse_info_;
		
		///<summary>
		/// 用户ID
		///</summary>
		
		private long? user_id_;
		
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
		
		///<summary>
		/// 订单状态：0、已完成；1、已退货
		///</summary>
		
		private int? order_status_;
		
		///<summary>
		/// 退货单信息，当订单状态为已退货时，返回该字段
		///</summary>
		
		private List<vipapis.vipmax.order.VipmaxRefundOrder> refund_orders_;
		
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
		public vipapis.vipmax.order.WarehouseInfo GetSales_warehouse_info(){
			return this.sales_warehouse_info_;
		}
		
		public void SetSales_warehouse_info(vipapis.vipmax.order.WarehouseInfo value){
			this.sales_warehouse_info_ = value;
		}
		public long? GetUser_id(){
			return this.user_id_;
		}
		
		public void SetUser_id(long? value){
			this.user_id_ = value;
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
		public int? GetOrder_status(){
			return this.order_status_;
		}
		
		public void SetOrder_status(int? value){
			this.order_status_ = value;
		}
		public List<vipapis.vipmax.order.VipmaxRefundOrder> GetRefund_orders(){
			return this.refund_orders_;
		}
		
		public void SetRefund_orders(List<vipapis.vipmax.order.VipmaxRefundOrder> value){
			this.refund_orders_ = value;
		}
		
	}
	
}