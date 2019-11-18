using System;
using System.Collections.Generic;
using System.Text;

namespace vipapis.xstore.cc.transferring.api{
	
	
	
	
	
	public class TransferringOrderDeliveryList {
		
		///<summary>
		/// 线下店主体：xstorebuy、maxxbuy
		///</summary>
		
		private string company_code_;
		
		///<summary>
		/// 中台调拨单号
		///</summary>
		
		private string transferring_order_no_;
		
		///<summary>
		/// 收货仓库代码
		///</summary>
		
		private string delivery_warehouse_code_;
		
		///<summary>
		/// 调拨出库日期
		///</summary>
		
		private System.DateTime? delivery_date_;
		
		///<summary>
		/// 调拨类型，1:大仓-门店；2:门店-门店；3:门店-大仓；4:大仓-大仓
		///</summary>
		
		private byte? transferring_type_;
		
		///<summary>
		/// 调出仓
		///</summary>
		
		private string src_warehouse_code_;
		
		///<summary>
		/// 调入仓
		///</summary>
		
		private string dest_warehouse_code_;
		
		public string GetCompany_code(){
			return this.company_code_;
		}
		
		public void SetCompany_code(string value){
			this.company_code_ = value;
		}
		public string GetTransferring_order_no(){
			return this.transferring_order_no_;
		}
		
		public void SetTransferring_order_no(string value){
			this.transferring_order_no_ = value;
		}
		public string GetDelivery_warehouse_code(){
			return this.delivery_warehouse_code_;
		}
		
		public void SetDelivery_warehouse_code(string value){
			this.delivery_warehouse_code_ = value;
		}
		public System.DateTime? GetDelivery_date(){
			return this.delivery_date_;
		}
		
		public void SetDelivery_date(System.DateTime? value){
			this.delivery_date_ = value;
		}
		public byte? GetTransferring_type(){
			return this.transferring_type_;
		}
		
		public void SetTransferring_type(byte? value){
			this.transferring_type_ = value;
		}
		public string GetSrc_warehouse_code(){
			return this.src_warehouse_code_;
		}
		
		public void SetSrc_warehouse_code(string value){
			this.src_warehouse_code_ = value;
		}
		public string GetDest_warehouse_code(){
			return this.dest_warehouse_code_;
		}
		
		public void SetDest_warehouse_code(string value){
			this.dest_warehouse_code_ = value;
		}
		
	}
	
}