using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.xstore.order.common.pojo.vo{
	
	
	
	
	
	public class InfErpMRetailPayItemVO {
		
		///<summary>
		/// 主键id
		///</summary>
		
		private long? id_;
		
		///<summary>
		/// 主表ID
		///</summary>
		
		private long? mRetailId_;
		
		///<summary>
		/// 币种ID
		///</summary>
		
		private long? cCurrencyId_;
		
		///<summary>
		/// 币种
		///</summary>
		
		private string cCurrency_;
		
		///<summary>
		/// 付款方式ID
		///</summary>
		
		private long? cPaywayId_;
		
		///<summary>
		/// 付款方式
		///</summary>
		
		private string cPayway_;
		
		///<summary>
		/// 付款金额
		///</summary>
		
		private string payamount_;
		
		///<summary>
		/// 备注
		///</summary>
		
		private string description_;
		
		///<summary>
		/// 支付流水号
		///</summary>
		
		private string rfidno_;
		
		///<summary>
		/// 记录创建时间
		///</summary>
		
		private long? createTime_;
		
		///<summary>
		/// 记录更新时间
		///</summary>
		
		private long? updateTime_;
		
		///<summary>
		/// 是否逻辑删除，0 否，1 是
		///</summary>
		
		private int? isDeleted_;
		
		public long? GetId(){
			return this.id_;
		}
		
		public void SetId(long? value){
			this.id_ = value;
		}
		public long? GetMRetailId(){
			return this.mRetailId_;
		}
		
		public void SetMRetailId(long? value){
			this.mRetailId_ = value;
		}
		public long? GetCCurrencyId(){
			return this.cCurrencyId_;
		}
		
		public void SetCCurrencyId(long? value){
			this.cCurrencyId_ = value;
		}
		public string GetCCurrency(){
			return this.cCurrency_;
		}
		
		public void SetCCurrency(string value){
			this.cCurrency_ = value;
		}
		public long? GetCPaywayId(){
			return this.cPaywayId_;
		}
		
		public void SetCPaywayId(long? value){
			this.cPaywayId_ = value;
		}
		public string GetCPayway(){
			return this.cPayway_;
		}
		
		public void SetCPayway(string value){
			this.cPayway_ = value;
		}
		public string GetPayamount(){
			return this.payamount_;
		}
		
		public void SetPayamount(string value){
			this.payamount_ = value;
		}
		public string GetDescription(){
			return this.description_;
		}
		
		public void SetDescription(string value){
			this.description_ = value;
		}
		public string GetRfidno(){
			return this.rfidno_;
		}
		
		public void SetRfidno(string value){
			this.rfidno_ = value;
		}
		public long? GetCreateTime(){
			return this.createTime_;
		}
		
		public void SetCreateTime(long? value){
			this.createTime_ = value;
		}
		public long? GetUpdateTime(){
			return this.updateTime_;
		}
		
		public void SetUpdateTime(long? value){
			this.updateTime_ = value;
		}
		public int? GetIsDeleted(){
			return this.isDeleted_;
		}
		
		public void SetIsDeleted(int? value){
			this.isDeleted_ = value;
		}
		
	}
	
}