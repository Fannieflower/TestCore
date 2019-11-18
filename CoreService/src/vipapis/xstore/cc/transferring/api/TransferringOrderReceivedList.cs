using System;
using System.Collections.Generic;
using System.Text;

namespace vipapis.xstore.cc.transferring.api{
	
	
	
	
	
	public class TransferringOrderReceivedList {
		
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
		
		private string received_warehouse_code_;
		
		///<summary>
		/// 调拨入库日期
		///</summary>
		
		private System.DateTime? received_date_;
		
		///<summary>
		/// 调拨类型，1:大仓-门店；2:门店-门店；3:门店-大仓
		///</summary>
		
		private int? transferring_type_;
		
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
		public string GetReceived_warehouse_code(){
			return this.received_warehouse_code_;
		}
		
		public void SetReceived_warehouse_code(string value){
			this.received_warehouse_code_ = value;
		}
		public System.DateTime? GetReceived_date(){
			return this.received_date_;
		}
		
		public void SetReceived_date(System.DateTime? value){
			this.received_date_ = value;
		}
		public int? GetTransferring_type(){
			return this.transferring_type_;
		}
		
		public void SetTransferring_type(int? value){
			this.transferring_type_ = value;
		}
		
	}
	
}