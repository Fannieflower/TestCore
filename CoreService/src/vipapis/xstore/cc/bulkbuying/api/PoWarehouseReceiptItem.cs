using System;
using System.Collections.Generic;
using System.Text;

namespace vipapis.xstore.cc.bulkbuying.api{
	
	
	
	
	
	public class PoWarehouseReceiptItem {
		
		///<summary>
		/// 行记录id
		///</summary>
		
		private string id_;
		
		///<summary>
		/// 商品条码
		///</summary>
		
		private string barcode_;
		
		///<summary>
		/// 收货数量
		///</summary>
		
		private int? receive_quantity_;
		
		///<summary>
		/// 成本价
		///</summary>
		
		private double? cost_price_;
		
		public string GetId(){
			return this.id_;
		}
		
		public void SetId(string value){
			this.id_ = value;
		}
		public string GetBarcode(){
			return this.barcode_;
		}
		
		public void SetBarcode(string value){
			this.barcode_ = value;
		}
		public int? GetReceive_quantity(){
			return this.receive_quantity_;
		}
		
		public void SetReceive_quantity(int? value){
			this.receive_quantity_ = value;
		}
		public double? GetCost_price(){
			return this.cost_price_;
		}
		
		public void SetCost_price(double? value){
			this.cost_price_ = value;
		}
		
	}
	
}