using System;
using System.Collections.Generic;
using System.Text;

namespace vipapis.xstore.cc.bulkbuying.api{
	
	
	
	
	
	public class UpdatePoRefundRealQtyReq {
		
		///<summary>
		/// 退供单号
		///</summary>
		
		private string refund_no_;
		
		///<summary>
		/// 退供出仓单号(废弃)
		///</summary>
		
		private string refund_receipt_no_;
		
		///<summary>
		/// 退供仓库编码
		///</summary>
		
		private string refund_warehouse_code_;
		
		///<summary>
		/// 退供出仓时间
		///</summary>
		
		private System.DateTime? refund_time_;
		
		///<summary>
		/// 退供单的明细总行数
		///</summary>
		
		private int? total_line_qty_;
		
		///<summary>
		/// 退供的商品列表
		///</summary>
		
		private List<vipapis.xstore.cc.bulkbuying.api.PoRefundRealItem> refund_items_;
		
		public string GetRefund_no(){
			return this.refund_no_;
		}
		
		public void SetRefund_no(string value){
			this.refund_no_ = value;
		}
		public string GetRefund_receipt_no(){
			return this.refund_receipt_no_;
		}
		
		public void SetRefund_receipt_no(string value){
			this.refund_receipt_no_ = value;
		}
		public string GetRefund_warehouse_code(){
			return this.refund_warehouse_code_;
		}
		
		public void SetRefund_warehouse_code(string value){
			this.refund_warehouse_code_ = value;
		}
		public System.DateTime? GetRefund_time(){
			return this.refund_time_;
		}
		
		public void SetRefund_time(System.DateTime? value){
			this.refund_time_ = value;
		}
		public int? GetTotal_line_qty(){
			return this.total_line_qty_;
		}
		
		public void SetTotal_line_qty(int? value){
			this.total_line_qty_ = value;
		}
		public List<vipapis.xstore.cc.bulkbuying.api.PoRefundRealItem> GetRefund_items(){
			return this.refund_items_;
		}
		
		public void SetRefund_items(List<vipapis.xstore.cc.bulkbuying.api.PoRefundRealItem> value){
			this.refund_items_ = value;
		}
		
	}
	
}