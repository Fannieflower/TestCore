using System;
using System.Collections.Generic;
using System.Text;

namespace vipapis.order{
	
	
	
	
	
	public class OxoOrderbarcodes {
		
		///<summary>
		/// 商品条码
		///</summary>
		
		private string barcode_;
		
		///<summary>
		/// 数量
		///</summary>
		
		private int? amount_;
		
		///<summary>
		/// 客退申请单详情
		///</summary>
		
		private List<vipapis.order.OxoOrderReturnApply> returnApply_;
		
		public string GetBarcode(){
			return this.barcode_;
		}
		
		public void SetBarcode(string value){
			this.barcode_ = value;
		}
		public int? GetAmount(){
			return this.amount_;
		}
		
		public void SetAmount(int? value){
			this.amount_ = value;
		}
		public List<vipapis.order.OxoOrderReturnApply> GetReturnApply(){
			return this.returnApply_;
		}
		
		public void SetReturnApply(List<vipapis.order.OxoOrderReturnApply> value){
			this.returnApply_ = value;
		}
		
	}
	
}