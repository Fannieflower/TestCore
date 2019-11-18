using System;
using System.Collections.Generic;
using System.Text;

namespace vipapis.order{
	
	
	
	
	
	public class OxoReturnOrder {
		
		///<summary>
		/// 订单编号
		///</summary>
		
		private string order_id_;
		
		///<summary>
		/// 订单创建时间
		///</summary>
		
		private string order_create_time_;
		
		///<summary>
		/// 收货人
		///</summary>
		
		private string buyer_;
		
		///<summary>
		/// 收货详细地址
		///</summary>
		
		private string address_;
		
		///<summary>
		/// 收货人手机号码
		///</summary>
		
		private string mobile_;
		
		///<summary>
		/// 收货人联系电话
		///</summary>
		
		private string tel_;
		
		///<summary>
		/// 商品列表
		///</summary>
		
		private List<vipapis.order.OxoOrderbarcodes> barcodes_;
		
		public string GetOrder_id(){
			return this.order_id_;
		}
		
		public void SetOrder_id(string value){
			this.order_id_ = value;
		}
		public string GetOrder_create_time(){
			return this.order_create_time_;
		}
		
		public void SetOrder_create_time(string value){
			this.order_create_time_ = value;
		}
		public string GetBuyer(){
			return this.buyer_;
		}
		
		public void SetBuyer(string value){
			this.buyer_ = value;
		}
		public string GetAddress(){
			return this.address_;
		}
		
		public void SetAddress(string value){
			this.address_ = value;
		}
		public string GetMobile(){
			return this.mobile_;
		}
		
		public void SetMobile(string value){
			this.mobile_ = value;
		}
		public string GetTel(){
			return this.tel_;
		}
		
		public void SetTel(string value){
			this.tel_ = value;
		}
		public List<vipapis.order.OxoOrderbarcodes> GetBarcodes(){
			return this.barcodes_;
		}
		
		public void SetBarcodes(List<vipapis.order.OxoOrderbarcodes> value){
			this.barcodes_ = value;
		}
		
	}
	
}