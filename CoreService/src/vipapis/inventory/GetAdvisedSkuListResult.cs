using System;
using System.Collections.Generic;
using System.Text;

namespace vipapis.inventory{
	
	
	
	
	
	public class GetAdvisedSkuListResult {
		
		///<summary>
		/// 供应商ID
		///</summary>
		
		private int? vendor_id_;
		
		///<summary>
		/// 常态合作编码
		///</summary>
		
		private int? cooperation_no_;
		
		///<summary>
		/// 档期仓库编码
		///</summary>
		
		private string warehouse_;
		
		///<summary>
		/// 补货商品列表
		///</summary>
		
		private List<vipapis.inventory.AdvisedSku> list_;
		
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
		public List<vipapis.inventory.AdvisedSku> GetList(){
			return this.list_;
		}
		
		public void SetList(List<vipapis.inventory.AdvisedSku> value){
			this.list_ = value;
		}
		
	}
	
}