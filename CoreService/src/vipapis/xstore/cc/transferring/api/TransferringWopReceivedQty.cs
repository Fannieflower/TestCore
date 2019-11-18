using System;
using System.Collections.Generic;
using System.Text;

namespace vipapis.xstore.cc.transferring.api{
	
	
	
	
	
	public class TransferringWopReceivedQty {
		
		///<summary>
		/// 保证唯一，用作幂等
		///</summary>
		
		private string tx_id_;
		
		///<summary>
		/// 新零售中台/ERP新条码
		///</summary>
		
		private string barcode_;
		
		///<summary>
		/// 中台采购订单号
		///</summary>
		
		private string purchase_no_;
		
		///<summary>
		/// 实际收货数量，不能为负数
		///</summary>
		
		private int? received_quantity_;
		
		///<summary>
		/// 箱号
		///</summary>
		
		private string container_no_;
		
		///<summary>
		/// 外部系统PO
		///</summary>
		
		private string out_purchase_po_;
		
		///<summary>
		/// 货品等级
		///</summary>
		
		private string grade_;
		
		///<summary>
		/// 可售状态, 枚举值 默认为0 , 0:可用
		///</summary>
		
		private int? sell_status_;
		
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
		public int? GetReceived_quantity(){
			return this.received_quantity_;
		}
		
		public void SetReceived_quantity(int? value){
			this.received_quantity_ = value;
		}
		public string GetContainer_no(){
			return this.container_no_;
		}
		
		public void SetContainer_no(string value){
			this.container_no_ = value;
		}
		public string GetOut_purchase_po(){
			return this.out_purchase_po_;
		}
		
		public void SetOut_purchase_po(string value){
			this.out_purchase_po_ = value;
		}
		public string GetGrade(){
			return this.grade_;
		}
		
		public void SetGrade(string value){
			this.grade_ = value;
		}
		public int? GetSell_status(){
			return this.sell_status_;
		}
		
		public void SetSell_status(int? value){
			this.sell_status_ = value;
		}
		
	}
	
}