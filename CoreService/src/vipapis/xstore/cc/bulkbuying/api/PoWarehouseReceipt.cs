using System;
using System.Collections.Generic;
using System.Text;

namespace vipapis.xstore.cc.bulkbuying.api{
	
	
	
	
	
	public class PoWarehouseReceipt {
		
		///<summary>
		/// 采购单编号
		///</summary>
		
		private string purchase_no_;
		
		///<summary>
		/// 线下店主体
		///</summary>
		
		private string company_code_;
		
		///<summary>
		/// 入库批次号
		///</summary>
		
		private string warehouse_receipt_no_;
		
		///<summary>
		/// 入库单总行数
		///</summary>
		
		private int? total_line_qty_;
		
		///<summary>
		/// 收货仓库代码
		///</summary>
		
		private string receive_warehouse_code_;
		
		///<summary>
		/// 采购入库日期(毫秒)
		///</summary>
		
		private System.DateTime? receive_time_;
		
		///<summary>
		/// 采购渠道，0=内采，1=外采
		///</summary>
		
		private byte? purchase_type_;
		
		///<summary>
		/// 创建人名称
		///</summary>
		
		private string buyer_name_;
		
		///<summary>
		/// 供应商编号
		///</summary>
		
		private string vendor_code_;
		
		///<summary>
		/// 供应商名称
		///</summary>
		
		private string vendor_name_;
		
		///<summary>
		/// 是否鲸仓
		///</summary>
		
		private byte? is_whale_warehouse_;
		
		public string GetPurchase_no(){
			return this.purchase_no_;
		}
		
		public void SetPurchase_no(string value){
			this.purchase_no_ = value;
		}
		public string GetCompany_code(){
			return this.company_code_;
		}
		
		public void SetCompany_code(string value){
			this.company_code_ = value;
		}
		public string GetWarehouse_receipt_no(){
			return this.warehouse_receipt_no_;
		}
		
		public void SetWarehouse_receipt_no(string value){
			this.warehouse_receipt_no_ = value;
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
		public byte? GetPurchase_type(){
			return this.purchase_type_;
		}
		
		public void SetPurchase_type(byte? value){
			this.purchase_type_ = value;
		}
		public string GetBuyer_name(){
			return this.buyer_name_;
		}
		
		public void SetBuyer_name(string value){
			this.buyer_name_ = value;
		}
		public string GetVendor_code(){
			return this.vendor_code_;
		}
		
		public void SetVendor_code(string value){
			this.vendor_code_ = value;
		}
		public string GetVendor_name(){
			return this.vendor_name_;
		}
		
		public void SetVendor_name(string value){
			this.vendor_name_ = value;
		}
		public byte? GetIs_whale_warehouse(){
			return this.is_whale_warehouse_;
		}
		
		public void SetIs_whale_warehouse(byte? value){
			this.is_whale_warehouse_ = value;
		}
		
	}
	
}