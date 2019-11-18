using System;
using System.Collections.Generic;
using System.Text;

namespace vipapis.inventory{
	
	
	
	
	
	public class AdvisedSku {
		
		///<summary>
		/// 条码
		///</summary>
		
		private string barcode_;
		
		///<summary>
		/// 建议补货数
		///</summary>
		
		private int? advise_num_;
		
		///<summary>
		/// 预购数量
		///</summary>
		
		private int? reservations_;
		
		public string GetBarcode(){
			return this.barcode_;
		}
		
		public void SetBarcode(string value){
			this.barcode_ = value;
		}
		public int? GetAdvise_num(){
			return this.advise_num_;
		}
		
		public void SetAdvise_num(int? value){
			this.advise_num_ = value;
		}
		public int? GetReservations(){
			return this.reservations_;
		}
		
		public void SetReservations(int? value){
			this.reservations_ = value;
		}
		
	}
	
}