using System;
using System.Collections.Generic;
using System.Text;

namespace vipapis.xstore.cc.bulkbuying.api{
	
	
	
	
	
	public class UpdatePoWarehouseReceiptQtyReq {
		
		///<summary>
		/// 入库批次号
		///</summary>
		
		private string warehouse_receipt_no_;
		
		///<summary>
		/// 采购单编码
		///</summary>
		
		private string purchase_no_;
		
		///<summary>
		/// 外部系统PO单据号,目前仅保存在入库单里不做业务处理
		///</summary>
		
		private string out_purchase_no_;
		
		///<summary>
		/// 入库批次的明细总行数
		///</summary>
		
		private int? total_line_qty_;
		
		///<summary>
		/// 收货仓库编码
		///</summary>
		
		private string receive_warehouse_code_;
		
		///<summary>
		/// 收货时间
		///</summary>
		
		private System.DateTime? receive_time_;
		
		///<summary>
		/// 商品收货数量列表
		///</summary>
		
		private List<vipapis.xstore.cc.bulkbuying.api.PoWarehouseReceiptQty> receive_items_;
		
		public string GetWarehouse_receipt_no(){
			return this.warehouse_receipt_no_;
		}
		
		public void SetWarehouse_receipt_no(string value){
			this.warehouse_receipt_no_ = value;
		}
		public string GetPurchase_no(){
			return this.purchase_no_;
		}
		
		public void SetPurchase_no(string value){
			this.purchase_no_ = value;
		}
		public string GetOut_purchase_no(){
			return this.out_purchase_no_;
		}
		
		public void SetOut_purchase_no(string value){
			this.out_purchase_no_ = value;
		}
		public int? GetTotal_line_qty(){
			return this.total_line_qty_;
		}
		
		public void SetTotal_line_qty(int? value){
			this.total_line_qty_ = value;
		}
		public string GetReceive_warehouse_code(){
			return this.receive_warehouse_code_;
		}
		
		public void SetReceive_warehouse_code(string value){
			this.receive_warehouse_code_ = value;
		}
		public System.DateTime? GetReceive_time(){
			return this.receive_time_;
		}
		
		public void SetReceive_time(System.DateTime? value){
			this.receive_time_ = value;
		}
		public List<vipapis.xstore.cc.bulkbuying.api.PoWarehouseReceiptQty> GetReceive_items(){
			return this.receive_items_;
		}
		
		public void SetReceive_items(List<vipapis.xstore.cc.bulkbuying.api.PoWarehouseReceiptQty> value){
			this.receive_items_ = value;
		}
		
	}
	
}