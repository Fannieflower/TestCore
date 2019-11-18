using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.vop.logistics{
	
	
	
	
	
	public class ShippingAddress {
		
		///<summary>
		/// 运单号
		///</summary>
		
		private string logistics_no_;
		
		///<summary>
		/// 退货地址
		///</summary>
		
		private com.vip.vop.logistics.Address address_;
		
		///<summary>
		/// 联系人
		///</summary>
		
		private com.vip.vop.logistics.Linkman linkman_;
		
		///<summary>
		/// 交易id
		///</summary>
		
		private string trade_id_;
		
		public string GetLogistics_no(){
			return this.logistics_no_;
		}
		
		public void SetLogistics_no(string value){
			this.logistics_no_ = value;
		}
		public com.vip.vop.logistics.Address GetAddress(){
			return this.address_;
		}
		
		public void SetAddress(com.vip.vop.logistics.Address value){
			this.address_ = value;
		}
		public com.vip.vop.logistics.Linkman GetLinkman(){
			return this.linkman_;
		}
		
		public void SetLinkman(com.vip.vop.logistics.Linkman value){
			this.linkman_ = value;
		}
		public string GetTrade_id(){
			return this.trade_id_;
		}
		
		public void SetTrade_id(string value){
			this.trade_id_ = value;
		}
		
	}
	
}