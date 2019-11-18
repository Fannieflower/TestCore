using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.tpc.api.model{
	
	
	
	
	
	public class ReturnInfo {
		
		///<summary>
		/// 唯品会订单号
		///</summary>
		
		private string orderSn_;
		
		///<summary>
		/// 完整地址，例如：广东省肇庆四市大旺高新区亚铝大街与北江大道交汇处唯品会物流园
		///</summary>
		
		private string address_;
		
		///<summary>
		/// 收件人姓名
		///</summary>
		
		private string name_;
		
		///<summary>
		/// 收件人手机号
		///</summary>
		
		private string phone_;
		
		///<summary>
		/// 收件人电话
		///</summary>
		
		private string mobile_;
		
		///<summary>
		/// 收件地址省份名称
		///</summary>
		
		private string province_;
		
		///<summary>
		/// 收件地址城市名称
		///</summary>
		
		private string city_;
		
		///<summary>
		/// 收件地址区县名称
		///</summary>
		
		private string county_;
		
		///<summary>
		/// 收件地址乡镇/街道名称
		///</summary>
		
		private string town_;
		
		///<summary>
		/// 收件地址邮政编码
		///</summary>
		
		private string postCode_;
		
		public string GetOrderSn(){
			return this.orderSn_;
		}
		
		public void SetOrderSn(string value){
			this.orderSn_ = value;
		}
		public string GetAddress(){
			return this.address_;
		}
		
		public void SetAddress(string value){
			this.address_ = value;
		}
		public string GetName(){
			return this.name_;
		}
		
		public void SetName(string value){
			this.name_ = value;
		}
		public string GetPhone(){
			return this.phone_;
		}
		
		public void SetPhone(string value){
			this.phone_ = value;
		}
		public string GetMobile(){
			return this.mobile_;
		}
		
		public void SetMobile(string value){
			this.mobile_ = value;
		}
		public string GetProvince(){
			return this.province_;
		}
		
		public void SetProvince(string value){
			this.province_ = value;
		}
		public string GetCity(){
			return this.city_;
		}
		
		public void SetCity(string value){
			this.city_ = value;
		}
		public string GetCounty(){
			return this.county_;
		}
		
		public void SetCounty(string value){
			this.county_ = value;
		}
		public string GetTown(){
			return this.town_;
		}
		
		public void SetTown(string value){
			this.town_ = value;
		}
		public string GetPostCode(){
			return this.postCode_;
		}
		
		public void SetPostCode(string value){
			this.postCode_ = value;
		}
		
	}
	
}