using System;
using System.Collections.Generic;
using System.Text;

namespace com.vip.vop.vcloud.invoice.api{
	
	
	
	
	
	public class QueryRefundReq {
		
		///<summary>
		/// 合作伙伴id
		///</summary>
		
		private long? partnerId_;
		
		///<summary>
		/// 渠道id
		///</summary>
		
		private long? channelId_;
		
		///<summary>
		/// 处理状态 0-未处理 1-已处理
		///</summary>
		
		private byte? dealType_;
		
		///<summary>
		/// 订单号
		///</summary>
		
		private string orderSn_;
		
		///<summary>
		/// 分页
		///</summary>
		
		private com.vip.vop.vcloud.common.api.Pagination pagination_;
		
		///<summary>
		/// 退款处理状态 pending-处理中 audited-已审核 complete-已完成
		///</summary>
		
		private string status_;
		
		///<summary>
		/// id
		///</summary>
		
		private long? id_;
		
		public long? GetPartnerId(){
			return this.partnerId_;
		}
		
		public void SetPartnerId(long? value){
			this.partnerId_ = value;
		}
		public long? GetChannelId(){
			return this.channelId_;
		}
		
		public void SetChannelId(long? value){
			this.channelId_ = value;
		}
		public byte? GetDealType(){
			return this.dealType_;
		}
		
		public void SetDealType(byte? value){
			this.dealType_ = value;
		}
		public string GetOrderSn(){
			return this.orderSn_;
		}
		
		public void SetOrderSn(string value){
			this.orderSn_ = value;
		}
		public com.vip.vop.vcloud.common.api.Pagination GetPagination(){
			return this.pagination_;
		}
		
		public void SetPagination(com.vip.vop.vcloud.common.api.Pagination value){
			this.pagination_ = value;
		}
		public string GetStatus(){
			return this.status_;
		}
		
		public void SetStatus(string value){
			this.status_ = value;
		}
		public long? GetId(){
			return this.id_;
		}
		
		public void SetId(long? value){
			this.id_ = value;
		}
		
	}
	
}