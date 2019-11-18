using System;
using System.Collections.Generic;
using System.Text;

namespace vipapis.tpc.service{
	
	
	
	
	
	public class GoodsPack {
		
		///<summary>
		/// 揽收到的商品条码
		///</summary>
		
		private string barcode_;
		
		///<summary>
		/// 揽收到的商品名称
		///</summary>
		
		private string goodsName_;
		
		///<summary>
		/// 预计揽件数量（揽件单数量）
		///</summary>
		
		private long? preAmount_;
		
		///<summary>
		/// 实揽数量
		///</summary>
		
		private long? amount_;
		
		///<summary>
		/// 商品序列号（部分商品需要）
		///</summary>
		
		private string serialNum_;
		
		public string GetBarcode(){
			return this.barcode_;
		}
		
		public void SetBarcode(string value){
			this.barcode_ = value;
		}
		public string GetGoodsName(){
			return this.goodsName_;
		}
		
		public void SetGoodsName(string value){
			this.goodsName_ = value;
		}
		public long? GetPreAmount(){
			return this.preAmount_;
		}
		
		public void SetPreAmount(long? value){
			this.preAmount_ = value;
		}
		public long? GetAmount(){
			return this.amount_;
		}
		
		public void SetAmount(long? value){
			this.amount_ = value;
		}
		public string GetSerialNum(){
			return this.serialNum_;
		}
		
		public void SetSerialNum(string value){
			this.serialNum_ = value;
		}
		
	}
	
}