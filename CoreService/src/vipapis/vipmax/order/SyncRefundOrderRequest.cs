using System;
using System.Collections.Generic;
using System.Text;

namespace vipapis.vipmax.order{
	
	
	
	
	
	public class SyncRefundOrderRequest {
		
		///<summary>
		/// 退货单商家订单号
		///</summary>
		
		private string refund_order_sn_;
		
		///<summary>
		/// 产生退货的原商家订单号
		///</summary>
		
		private string origin_out_order_sn_;
		
		///<summary>
		/// 用户退货时间
		///</summary>
		
		private System.DateTime? refund_time_;
		
		///<summary>
		/// 产生退货的仓库编号
		///</summary>
		
		private string refund_warehouse_;
		
		///<summary>
		/// 退货订单明细
		///</summary>
		
		private List<vipapis.vipmax.order.VipmaxRefundOrderDetail> order_detail_;
		
		///<summary>
		/// 退款总金额
		///</summary>
		
		private double? total_refund_fee_;
		
		///<summary>
		/// 公司代码:xstorebuy，maxxbuy
		///</summary>
		
		private string company_code_;
		
		public string GetRefund_order_sn(){
			return this.refund_order_sn_;
		}
		
		public void SetRefund_order_sn(string value){
			this.refund_order_sn_ = value;
		}
		public string GetOrigin_out_order_sn(){
			return this.origin_out_order_sn_;
		}
		
		public void SetOrigin_out_order_sn(string value){
			this.origin_out_order_sn_ = value;
		}
		public System.DateTime? GetRefund_time(){
			return this.refund_time_;
		}
		
		public void SetRefund_time(System.DateTime? value){
			this.refund_time_ = value;
		}
		public string GetRefund_warehouse(){
			return this.refund_warehouse_;
		}
		
		public void SetRefund_warehouse(string value){
			this.refund_warehouse_ = value;
		}
		public List<vipapis.vipmax.order.VipmaxRefundOrderDetail> GetOrder_detail(){
			return this.order_detail_;
		}
		
		public void SetOrder_detail(List<vipapis.vipmax.order.VipmaxRefundOrderDetail> value){
			this.order_detail_ = value;
		}
		public double? GetTotal_refund_fee(){
			return this.total_refund_fee_;
		}
		
		public void SetTotal_refund_fee(double? value){
			this.total_refund_fee_ = value;
		}
		public string GetCompany_code(){
			return this.company_code_;
		}
		
		public void SetCompany_code(string value){
			this.company_code_ = value;
		}
		
	}
	
}