using System;
using System.Collections.Generic;
using System.Text;

namespace vipapis.jitx{
	
	
	
	
	
	public class WarehouseInfo {
		
		///<summary>
		/// 仓库编码
		///</summary>
		
		private string warehouse_code_;
		
		///<summary>
		/// 仓库名称
		///</summary>
		
		private string warehouse_name_;
		
		///<summary>
		/// 仓库地址
		///</summary>
		
		private string warehouse_address_;
		
		public string GetWarehouse_code(){
			return this.warehouse_code_;
		}
		
		public void SetWarehouse_code(string value){
			this.warehouse_code_ = value;
		}
		public string GetWarehouse_name(){
			return this.warehouse_name_;
		}
		
		public void SetWarehouse_name(string value){
			this.warehouse_name_ = value;
		}
		public string GetWarehouse_address(){
			return this.warehouse_address_;
		}
		
		public void SetWarehouse_address(string value){
			this.warehouse_address_ = value;
		}
		
	}
	
}