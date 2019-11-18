using System;
using System.Collections.Generic;
using System.Text;

namespace vipapis.xstore.cc.bulkbuying.api{
	
	
	
	
	
	public class PoRefundRealItem {
		
		///<summary>
		/// 事务号
		///</summary>
		
		private string txid_;
		
		///<summary>
		/// 采购单号
		///</summary>
		
		private string purchase_no_;
		
		///<summary>
		/// 商品条码
		///</summary>
		
		private string barcode_;
		
		///<summary>
		/// 残次等级小类(100,101,102,210,211,212,220,221,222等，参照公司的残次等级定义)
		///</summary>
		
		private string sub_disability_level_;
		
		///<summary>
		/// 可售状态(0:不可售,1:可售)
		///</summary>
		
		private byte? selling_status_;
		
		///<summary>
		/// 箱号
		///</summary>
		
		private string box_no_;
		
		///<summary>
		/// 实际退供数量
		///</summary>
		
		private int? refund_quantity_;
		
		public string GetTxid(){
			return this.txid_;
		}
		
		public void SetTxid(string value){
			this.txid_ = value;
		}
		public string GetPurchase_no(){
			return this.purchase_no_;
		}
		
		public void SetPurchase_no(string value){
			this.purchase_no_ = value;
		}
		public string GetBarcode(){
			return this.barcode_;
		}
		
		public void SetBarcode(string value){
			this.barcode_ = value;
		}
		public string GetSub_disability_level(){
			return this.sub_disability_level_;
		}
		
		public void SetSub_disability_level(string value){
			this.sub_disability_level_ = value;
		}
		public byte? GetSelling_status(){
			return this.selling_status_;
		}
		
		public void SetSelling_status(byte? value){
			this.selling_status_ = value;
		}
		public string GetBox_no(){
			return this.box_no_;
		}
		
		public void SetBox_no(string value){
			this.box_no_ = value;
		}
		public int? GetRefund_quantity(){
			return this.refund_quantity_;
		}
		
		public void SetRefund_quantity(int? value){
			this.refund_quantity_ = value;
		}
		
	}
	
}