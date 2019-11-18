using System;
using System.Collections.Generic;
using System.Text;

namespace vipapis.inventory{
	
	
	
	
	
	public class CooperationNo {
		
		///<summary>
		/// 供应商ID
		///</summary>
		
		private int? vendor_id_;
		
		///<summary>
		/// 常态合作编码
		///</summary>
		
		private int? cooperation_no_;
		
		///<summary>
		/// 仓库编码
		///</summary>
		
		private string warehouse_;
		
		///<summary>
		/// 合作编码有效开始时间
		///</summary>
		
		private string sell_time_from_;
		
		///<summary>
		/// 合作编码有效结束时间
		///</summary>
		
		private string sell_time_to_;
		
		public int? GetVendor_id(){
			return this.vendor_id_;
		}
		
		public void SetVendor_id(int? value){
			this.vendor_id_ = value;
		}
		public int? GetCooperation_no(){
			return this.cooperation_no_;
		}
		
		public void SetCooperation_no(int? value){
			this.cooperation_no_ = value;
		}
		public string GetWarehouse(){
			return this.warehouse_;
		}
		
		public void SetWarehouse(string value){
			this.warehouse_ = value;
		}
		public string GetSell_time_from(){
			return this.sell_time_from_;
		}
		
		public void SetSell_time_from(string value){
			this.sell_time_from_ = value;
		}
		public string GetSell_time_to(){
			return this.sell_time_to_;
		}
		
		public void SetSell_time_to(string value){
			this.sell_time_to_ = value;
		}
		
	}
	
}