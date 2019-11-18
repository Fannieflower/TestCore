using System;
using System.Collections.Generic;
using System.Text;

namespace vipapis.vipmax.order{
	
	
	
	
	
	public class WarehouseInfo {
		
		///<summary>
		/// 仓库编码
		///</summary>
		
		private string warehouse_;
		
		///<summary>
		/// 仓库名称
		///</summary>
		
		private string warehouse_name_;
		
		///<summary>
		/// 仓库地址
		///</summary>
		
		private string warehouse_address_;
		
		///<summary>
		/// 负责人电话
		///</summary>
		
		private string warehouse_tel_;
		
		public string GetWarehouse(){
			return this.warehouse_;
		}
		
		public void SetWarehouse(string value){
			this.warehouse_ = value;
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
		public string GetWarehouse_tel(){
			return this.warehouse_tel_;
		}
		
		public void SetWarehouse_tel(string value){
			this.warehouse_tel_ = value;
		}
		
	}
	
}