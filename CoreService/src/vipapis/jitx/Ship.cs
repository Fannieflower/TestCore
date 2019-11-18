using System;
using System.Collections.Generic;
using System.Text;

namespace vipapis.jitx{
	
	
	
	
	
	public class Ship {
		
		///<summary>
		/// 订单号
		///</summary>
		
		private string order_sn_;
		
		///<summary>
		/// 发货仓库
		///</summary>
		
		private string delivery_warehouse_;
		
		///<summary>
		/// 包裹总数
		///</summary>
		
		private int? total_package_;
		
		///<summary>
		/// 包裹列表
		///</summary>
		
		private List<vipapis.jitx.Package> packages_;
		
		public string GetOrder_sn(){
			return this.order_sn_;
		}
		
		public void SetOrder_sn(string value){
			this.order_sn_ = value;
		}
		public string GetDelivery_warehouse(){
			return this.delivery_warehouse_;
		}
		
		public void SetDelivery_warehouse(string value){
			this.delivery_warehouse_ = value;
		}
		public int? GetTotal_package(){
			return this.total_package_;
		}
		
		public void SetTotal_package(int? value){
			this.total_package_ = value;
		}
		public List<vipapis.jitx.Package> GetPackages(){
			return this.packages_;
		}
		
		public void SetPackages(List<vipapis.jitx.Package> value){
			this.packages_ = value;
		}
		
	}
	
}