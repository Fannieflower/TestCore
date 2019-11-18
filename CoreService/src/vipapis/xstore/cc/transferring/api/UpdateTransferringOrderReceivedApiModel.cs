using System;
using System.Collections.Generic;
using System.Text;

namespace vipapis.xstore.cc.transferring.api{
	
	
	
	
	
	public class UpdateTransferringOrderReceivedApiModel {
		
		///<summary>
		/// 事务ID
		///</summary>
		
		private string tx_id_;
		
		///<summary>
		/// 中台条码
		///</summary>
		
		private string barcode_;
		
		///<summary>
		/// PO编号
		///</summary>
		
		private string purchase_no_;
		
		///<summary>
		/// 外部系统PO编号
		///</summary>
		
		private string out_purchase_no_;
		
		///<summary>
		/// 实际发货数量，不能为负数
		///</summary>
		
		private string received_quantity_;
		
		///<summary>
		/// 箱号
		///</summary>
		
		private string container_no_;
		
		public string GetTx_id(){
			return this.tx_id_;
		}
		
		public void SetTx_id(string value){
			this.tx_id_ = value;
		}
		public string GetBarcode(){
			return this.barcode_;
		}
		
		public void SetBarcode(string value){
			this.barcode_ = value;
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
		public string GetReceived_quantity(){
			return this.received_quantity_;
		}
		
		public void SetReceived_quantity(string value){
			this.received_quantity_ = value;
		}
		public string GetContainer_no(){
			return this.container_no_;
		}
		
		public void SetContainer_no(string value){
			this.container_no_ = value;
		}
		
	}
	
}