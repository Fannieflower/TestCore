using System;
using System.Collections.Generic;
using System.Text;

namespace vipapis.xstore.cc.bulkbuying.api{
	
	
	
	
	
	public class PurchaseOrderItem {
		
		///<summary>
		/// 采购单号
		///</summary>
		
		private string purchase_no_;
		
		///<summary>
		/// 商品条码
		///</summary>
		
		private string barcode_;
		
		///<summary>
		/// 已出仓数量
		///</summary>
		
		private int? purchase_quantity_;
		
		///<summary>
		/// 成本价
		///</summary>
		
		private string cost_price_;
		
		///<summary>
		/// 原条码
		///</summary>
		
		private string barcode_origin_;
		
		///<summary>
		/// 增值打印方式(0:不增值,1:吊牌,2:贴纸)
		///</summary>
		
		private byte? template_type_;
		
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
		public int? GetPurchase_quantity(){
			return this.purchase_quantity_;
		}
		
		public void SetPurchase_quantity(int? value){
			this.purchase_quantity_ = value;
		}
		public string GetCost_price(){
			return this.cost_price_;
		}
		
		public void SetCost_price(string value){
			this.cost_price_ = value;
		}
		public string GetBarcode_origin(){
			return this.barcode_origin_;
		}
		
		public void SetBarcode_origin(string value){
			this.barcode_origin_ = value;
		}
		public byte? GetTemplate_type(){
			return this.template_type_;
		}
		
		public void SetTemplate_type(byte? value){
			this.template_type_ = value;
		}
		
	}
	
}